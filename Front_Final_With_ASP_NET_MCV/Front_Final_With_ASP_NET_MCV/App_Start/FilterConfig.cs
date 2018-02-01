using System.Web;
using System.Web.Mvc;

namespace Front_Final_With_ASP_NET_MCV
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
