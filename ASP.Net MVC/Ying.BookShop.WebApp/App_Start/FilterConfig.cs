using System.Web;
using System.Web.Mvc;
using Ying.BookShop.WebApp.Models;

namespace Ying.BookShop.WebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new MyExceptionAttribute());    //注册自己写的异常捕获函数
        }
    }
}
