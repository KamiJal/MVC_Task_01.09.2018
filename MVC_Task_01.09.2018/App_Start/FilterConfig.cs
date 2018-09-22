using System.Web;
using System.Web.Mvc;

namespace MVC_Task_01._09._2018
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
