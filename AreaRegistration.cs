using System.Web.Mvc;

namespace SoftSupply.Help.Areas.GanSoftApp
{
    public class GanSoftProAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "GanSoftApp";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                AreaName,
                AreaName + "/{controller}/{action}/{id}",
                new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}