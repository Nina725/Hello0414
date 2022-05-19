using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web410816897.ViewModols;

namespace Web410816897.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View(new SignUpData());
        }
        [HttpPost]

        public ActionResult SignUp(SignUpData data)
        {
            
            if (ModelState.IsValid)
            {
                data.Msssage = "註冊成功";
            }
            return View(data);
        }
        

    }
}