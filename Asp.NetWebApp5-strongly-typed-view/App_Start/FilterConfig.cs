using System.Web;
using System.Web.Mvc;

namespace Asp.NetWebApp5_strongly_typed_view
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
