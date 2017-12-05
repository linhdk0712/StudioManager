using System.Data;
using System.Linq;
using System.Web.Helpers;
using System.Web.Mvc;
using Studio.Services;
using StudioApplication.Areas.SysAdmin.Models;

namespace StudioApplication.Areas.SysAdmin.Controllers
{
    public class SysAdminController : Controller
    {
        private readonly IStudioActiveService _studioActiveService;
        private readonly IStudioService _studioService;
        public SysAdminController(IStudioActiveService studioActiveService, IStudioService studioService)
        {
            _studioActiveService = studioActiveService;
            _studioService = studioService;
        }
        // GET: SysAdmin/SysAdmin
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetStudioActive()
        {
            const string SQL_STUDIO_ACTIVE = "select * from StudioActives";
            const string SQL_STUDIO = "select * from Studios";
            var studioActive = _studioActiveService.GetAllEntities(SQL_STUDIO_ACTIVE, null, CommandType.Text);
            var studio = _studioService.GetAllEntities(SQL_STUDIO, null, CommandType.Text);
            var result = from a in studioActive
                         join b in studio on a.StudioId equals b.StudioId
                         select new StudioActiveViewModel()
                         {
                             StudioId = a.StudioId,
                             StudioActiveId = a.StudioActiveId,
                             StudioCode = b.StudioCode,
                             StudioName = b.StudioName,
                             SkypeName = b.SkypeName,
                             PhoneNumber = b.PhoneNumber,
                             Email = b.Email,
                             Address = b.Address,
                             Logo = b.Logo,
                             ActiveFrom = a.ActiveFrom,
                             ActiveTo = a.ActiveTo
                         };

            return Json(new
            {
                data = result,
                status = true
            }, JsonRequestBehavior.AllowGet);
        }
    }
}