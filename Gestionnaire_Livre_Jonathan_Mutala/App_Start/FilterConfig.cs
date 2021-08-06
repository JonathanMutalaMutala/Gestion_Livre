using System.Web;
using System.Web.Mvc;

namespace Gestionnaire_Livre_Jonathan_Mutala
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
