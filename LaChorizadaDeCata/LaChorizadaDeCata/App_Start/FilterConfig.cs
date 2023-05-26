using System.Web;
using System.Web.Mvc;

namespace LaChorizadaDeCata
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
