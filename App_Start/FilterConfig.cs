using SessionMessage;
using System.Web;
using System.Web.Mvc;

namespace Demo
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
			filters.Add(new MvcAjaxMessagesFilterAttribute());
		}
		public static void RegisterWebApiGlobalFilters()
		{
			System.Web.Http.GlobalConfiguration.Configuration.Filters.Add(new AjaxMessagesFilterAttribute());
		}
	}
}
