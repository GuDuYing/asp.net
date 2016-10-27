using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ying.BookShop.IBLL;

namespace Ying.BookShop.WebApp.Controllers
{
    public class LoginController : Controller
    {
        //顾客信息实例
        Itb_customerinfoService customerInfo { get; set; }
        //管理员信息实例
        Itb_managerService manager { get; set; }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
    }
}