using System.Web.Mvc;

namespace StudioApplication.Areas.StudioAdmin
{
    public class StudioAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "StudioAdmin";

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "StudioAdmin_default",
                "StudioAdmin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}