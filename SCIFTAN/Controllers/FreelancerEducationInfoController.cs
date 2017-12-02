using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using SCIFTAN.DAL.DB.EF;
using SCIFTAN.BLL.IService;
using Microsoft.AspNet.Identity;
using SCIFTAN.BLL.Models;

namespace SCIFTAN.Controllers
{
    [Authorize]
    public class FreelancerEducationInfoController : Controller
    {
        private readonly IFreelancerEducationInfoService _iFreelancerEducationInfoService;
        public FreelancerEducationInfoController(IFreelancerEducationInfoService iFreelancerEducationInfoService)
        {
            _iFreelancerEducationInfoService = iFreelancerEducationInfoService;
        }
        public ActionResult Index()
        {
            return View(_iFreelancerEducationInfoService.GetAllByFreelancerId(User.Identity.GetUserId()));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Freelancer_Id,Degree,Institute,Year,Result,Subject")] FREELANCER_EDUCATION_INFO_Model fREELANCER_EDUCATION_INFO_Model)
        {
            if (ModelState.IsValid)
            {
                fREELANCER_EDUCATION_INFO_Model.Freelancer_Id = User.Identity.GetUserId();
                if (_iFreelancerEducationInfoService.InsertFreelancerEducation(fREELANCER_EDUCATION_INFO_Model)) ;
                {
                    return RedirectToAction("Index");
                }
            }

            return View(fREELANCER_EDUCATION_INFO_Model);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (User.Identity.GetUserId() == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FREELANCER_EDUCATION_INFO_Model fREELANCER_EDUCATION_INFO_Model = _iFreelancerEducationInfoService.GetById(id);
            if (fREELANCER_EDUCATION_INFO_Model == null)
            {
                return HttpNotFound();
            }
            return View(fREELANCER_EDUCATION_INFO_Model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Freelancer_Id,Degree,Institute,Year,Result,Subject")] FREELANCER_EDUCATION_INFO_Model fREELANCER_EDUCATION_INFO_Model)
        {
            if (ModelState.IsValid)
            {
                if (_iFreelancerEducationInfoService.UpdateFreelancerEducation(fREELANCER_EDUCATION_INFO_Model))
                {
                    return RedirectToAction("Index");
                }
            }
            return View(fREELANCER_EDUCATION_INFO_Model);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            _iFreelancerEducationInfoService.DeleteFreelancerEducation(id);
            return RedirectToAction("Index");

        }

    }
}
