using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CaseCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;

namespace CaseCoreApp.Controllers
{
    public class TargetAppController : Controller
    {
        Context context = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var list = context.TargetApps.Include(x=>x.User).ToList();
            return View(list);
        }

        [Authorize]
        [HttpGet]
        public IActionResult NewUrl()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewUrl(TargetApp targetapp)
        {
            var userinfo =JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("sessionuser"));
            TargetApp t = new TargetApp();
            t.userid = userinfo.userid;
            t.mail = userinfo.mail;
            t.name = targetapp.name;
            t.url = targetapp.url;
            t.interval = targetapp.interval;
            context.TargetApps.Add(t);
            context.SaveChanges();       
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult DeleteUrl(int id)
        {
            var row = context.TargetApps.Find(id);
            context.TargetApps.Remove(row);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public IActionResult UrlDetail(int id)
        {
            var row = context.TargetApps.Find(id);
            return View("UrlDetail", row);
        }
        [Authorize]
        [HttpPost]
        public IActionResult EditUrl(TargetApp t)
        {
            var row = context.TargetApps.Find(t.id);
            row.name = t.name;
            row.url = t.url;
            row.interval = t.interval;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult Logs(TargetApp row)
        {
            var list = context.Logs.Where(x=>x.targetid==row.id).OrderByDescending(x=>x.id).Take(10).ToList();
            return View(list);
        }
        public async Task<IActionResult> UrlControl(int id)
        {
            var row = context.TargetApps.Include(x => x.User).ToList().Find(x=>x.id==id);
            //var row = context.TargetApps.Find(id);
            int time = row.interval * 1000;           
            int sayi = 1;
            string status = "";
            while (sayi<=2)
            {              
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(row.url);
                    using (HttpWebResponse responce = (HttpWebResponse)request.GetResponse())
                    {
                        if (responce.StatusCode == HttpStatusCode.OK)
                        {
                            status = "Status Code=200";
                            LogInsert(row, status);
                        }
                        else if (responce.StatusCode == HttpStatusCode.BadRequest)
                        {
                            status = "Status Code=400";
                            LogInsert(row, status);
                        }
                        else if (responce.StatusCode == HttpStatusCode.NotFound)
                        {
                            status = "Status Code=404";
                            LogInsert(row, status);
                        }
                        else if (responce.StatusCode == HttpStatusCode.InternalServerError)
                        {
                            status = "Status Code=505";
                            LogInsert(row, status);
                        }
                    }
                    sayi++;                  
                    await Task.Delay(time);
                }
                catch (Exception ex)
                {
                    sayi++;
                    status = "Sunucuya erişim yok.";
                    LogInsert(row, status);
                    Contact(row);
                    return RedirectToAction("Logs", row);
                }               
            }                                  
            return RedirectToAction("Logs", row);
        }

        public void LogInsert(TargetApp targetapp, string status)
        {
            Log log = new Log();
            log.targetid = targetapp.id;
            log.username = targetapp.User.username;
            log.url = targetapp.url;
            log.date = DateTime.Now;
            log.status = status;
            context.Logs.Add(log);
            context.SaveChanges();
        }

        public void Contact(TargetApp t)  //Mail sınıfından m diye bir değişken tanımlarız
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); 
                client.Credentials = new NetworkCredential("guclukuyumcu@gmail.com", "******");
                client.EnableSsl = true;
                MailMessage msj = new MailMessage(); 
                msj.From = new MailAddress("guclukuyumcu@gmail.com"); 
                msj.To.Add(t.mail); 
                msj.Subject = "Uyarı"; 
                msj.Body = t.url + "adresine erişim yoktur."; 
                client.Send(msj);                              
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}