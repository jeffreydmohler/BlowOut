using System.Web;
using System.Web.Mvc;

namespace BlowOut_Checkpoint1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
