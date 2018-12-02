using System.Web;
using System.Web.Mvc;

namespace IT583.OAE.Employee.ASP.NET.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
