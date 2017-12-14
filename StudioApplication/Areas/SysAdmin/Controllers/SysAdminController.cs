using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web.Helpers;
using System.Web.Mvc;
using Studio.Services;
using StudioApplication.Areas.SysAdmin.Models;
using StudioCommon;

namespace StudioApplication.Areas.SysAdmin.Controllers
{
    public class SysAdminController : Controller
    {
        private readonly IStudioActiveService _studioActiveService;
        private readonly IStudioService _studioService;
        private readonly IEncrypt _encrypt;
        public SysAdminController(IStudioActiveService studioActiveService, IStudioService studioService, IEncrypt encrypt)
        {
            _studioActiveService = studioActiveService;
            _studioService = studioService;
            _encrypt = encrypt;
        }
        // GET: SysAdmin/SysAdmin
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetStudioActive()
        {
            var result = GetStudioActiveViewModels();
            return Json(new
            {
                data = result,
                status = true
            }, JsonRequestBehavior.AllowGet);
        }
        [AllowAnonymous]
        public JsonResult Edit(Guid id)
        {
            var model = GetStudioActiveViewModels();
            var result = model.FirstOrDefault(x => x.StudioActiveId == id);
            return Json(new
            {
               status = result
            }, JsonRequestBehavior.AllowGet);
        }
        [AllowAnonymous]
        public JsonResult Delete(int id)
        {
            return Json(new
            {
                status = id
            }, JsonRequestBehavior.AllowGet);
        }

        private IEnumerable<StudioActiveViewModel> GetStudioActiveViewModels()
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
            return result;
        }
    }
}