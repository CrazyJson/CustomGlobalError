using System.Web;
using System.Web.Mvc;

namespace MvcGlobalError
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomErrorAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}