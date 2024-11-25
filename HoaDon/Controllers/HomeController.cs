using HoaDon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HoaDon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HoaDon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HoaDon(MD_ThongTinHoaDon hoadon)
        {
            if (ModelState.IsValid)
            {
               
            }
            return View();
        }

    }
}