using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites1.Models;

namespace PartyInvites1.Controllers
{
    public class HomeController : Controller
    {
  
        [HttpGet]
        public ActionResult Hello()
        {;
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View();
        }
        [HttpGet]
        public ActionResult RsvpFrom()
        {
            return View();
        }
            
        [HttpPost]
        public ActionResult RsvpFrom(GuestResponse gr)
        {
            if (ModelState.IsValid)
            {

            return View("Thanks", gr);
            } else 
            {
                return View();
            }
        }
    }
}