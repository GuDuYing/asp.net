using log4net;
using Spring.Web.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ying.BookShop.WebApp.Models;

namespace Ying.BookShop.WebApp
{
    public class MvcApplication : SpringMvcApplication       
    {
        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();    //读取Log4Net的配置信息
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //开启一个线程，扫描异常信息队列
            string filePath = Server.MapPath("/Log/");
            ThreadPool.QueueUserWorkItem((a) =>
            {
                while (true)
                {
                    //判断队列中是否有数据，如果有保存进日志中，没有则线程休息5秒
                    if (MyExceptionAttribute.ExceptionQueue.Count > 0)
                    {
                        Exception ex = MyExceptionAttribute.ExceptionQueue.Dequeue();
                        if(ex!=null)
                        {
                            //将异常信息写到日志文件中
                            //string fileName = DateTime.Now.ToString("yyyy-mm-dd");
                            //File.AppendAllText(filePath + fileName + ".txt", ex.ToString(), System.Text.Encoding.UTF8);
                            ILog logger = LogManager.GetLogger("ErrorMsg");
                            logger.Error(ex.ToString());
                        }
                        else
                        {
                            Thread.Sleep(5000);
                        }
                    }
                    else
                    {
                        Thread.Sleep(5000);
                    }
                }
            }, filePath);

        }
    }
}
