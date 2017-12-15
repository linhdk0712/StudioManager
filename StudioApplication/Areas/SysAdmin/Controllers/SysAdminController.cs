using Dapper;
using Studio.Services;
using StudioApplication.Areas.SysAdmin.Models;
using StudioCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(NewStudioViewModel model, HttpPostedFileBase logo)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var pathLogo = Path.Combine(Server.MapPath("~/Content/Images"), logo.FileName);
            //var createBy = Session["systemadmin"].ToString();
            var createBy = "";
            const string SQL_QUERY_INSERT = "InsertNewStudio";
            var parameters = new DynamicParameters();
            parameters.Add("StudioId", Guid.NewGuid());
            parameters.Add("StudioCode", model.StudioCode);
            parameters.Add("StudioName", model.StudioName);
            parameters.Add("SkypeName", model.SkypeName);
            parameters.Add("PhoneNumber", model.PhoneNumber);
            parameters.Add("Email", model.Email);
            parameters.Add("Address", model.Address);
            parameters.Add("Logo", logo.FileName);
            parameters.Add("Status", model.Status);
            parameters.Add("CreateDate", DateTime.Now);
            parameters.Add("CreateBy", createBy);
            var result = _studioService.Create(SQL_QUERY_INSERT, parameters, commandType: CommandType.StoredProcedure);
            if (result == 0)
            {
               ViewBag.message = "Chưa thêm được dữ liệu";
                return View();
            }
            logo.SaveAs(pathLogo);
            return RedirectToAction("Index");
        }

        public ActionResult CreateActiveStudio()
        {
            return View();
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

        public JsonResult GetStudioWithCode(string code)
        {
            var check = false;
            const string SQL_STUDIO_CODE = @"SELECT [StudioId],[StudioCode],[StudioName],[SkypeName],[PhoneNumber],[Email],[Address],[Logo],[CreateDate]
                                            ,[CreateBy]
                                            ,[Status]
                                            ,[ModifyDate]
                                            ,[ModifyBy]
                                            FROM [SocialGoal].[dbo].[Studios] WHERE StudioCode = @StudioCode";
            var param = new DynamicParameters();
            param.Add("@StudioCode",code);
            var result = _studioService.GetEntity(SQL_STUDIO_CODE,param,commandType:CommandType.Text);
            if (result != null)
            {
                check = true;
            }
            return Json(new
            {
                status = check
            }, JsonRequestBehavior.AllowGet);
        }
    }
}