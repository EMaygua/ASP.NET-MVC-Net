using System.Web;
using System.Web.Mvc;

namespace MVC_APP_for_NET_41
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
