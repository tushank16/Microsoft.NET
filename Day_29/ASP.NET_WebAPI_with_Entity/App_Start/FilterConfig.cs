using System.Web;
using System.Web.Mvc;

namespace ASP.NET_WebAPI_with_Entity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
