using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaseCoreApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaseCoreApp.Controllers
{
    public class UserController : Controller
    {
        Context context = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var userlist = context.Users.ToList();
            return View(userlist);
        }
    }
}