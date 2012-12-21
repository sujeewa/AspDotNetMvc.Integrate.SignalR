using System.Web;
using System.Web.Mvc;

namespace AspDotNetMvc.Integrate.SignalR
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}