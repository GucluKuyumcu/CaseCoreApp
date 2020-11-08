using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CaseCoreApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CaseCoreApp.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            //HttpContext.SignOutAsync();
            return View();
        }

        public async Task<IActionResult> Login(User u)
        {          
            var data = context.Users.FirstOrDefault(x => x.username == u.username && x.password == u.password);
            if (data != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, u.username)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);

                var userinfo = new User() { userid = data.userid, mail = data.mail };
                HttpContext.Session.SetString("sessionuser", JsonConvert.SerializeObject(userinfo));
                return RedirectToAction("Index", "TargetApp");
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {          
            await HttpContext.SignOutAsync();       
            return RedirectToAction("Login", "Login");
        }
    }
}