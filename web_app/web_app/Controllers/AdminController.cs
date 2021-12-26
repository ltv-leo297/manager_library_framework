using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using web_app.Models;

namespace web_app.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult AdminDanhMuc()
        {
            return View();
        }
        public IActionResult admin_donhang()
        {
            return View();
        }
    }
}
