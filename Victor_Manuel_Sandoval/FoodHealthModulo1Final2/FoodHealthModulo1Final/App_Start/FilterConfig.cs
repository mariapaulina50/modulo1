using System.Web;
using System.Web.Mvc;

namespace FoodHealthModulo1Final
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
