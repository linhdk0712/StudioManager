using System.Web.Mvc;

namespace StudioApplication.Areas.SysAdmin
{
    public class SysAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "SysAdmin";

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SysAdmin_default",
                "SysAdmin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}