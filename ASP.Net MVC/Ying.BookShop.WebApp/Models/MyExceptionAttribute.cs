using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ying.BookShop.WebApp.Models
{
    public class MyExceptionAttribute:HandleErrorAttribute
    {
        //存放异常数据的队列
        public static Queue<Exception> ExceptionQueue = new Queue<Exception>();
        /// <summary>
        /// 捕获异常数据
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
            Exception ex = filterContext.Exception;
            //写入队列
            ExceptionQueue.Enqueue(ex);
            //跳转到错误页面
            filterContext.HttpContext.Response.Redirect("/Error.html");
        }
    }
}