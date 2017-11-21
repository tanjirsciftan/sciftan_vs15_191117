using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SCIFTAN.BLL.Models;
using SCIFTAN.DAL.DB.EF;
using SCIFTAN.BLL.IService;
using Microsoft.AspNet.Identity;

namespace SCIFTAN.Controllers
{
    public class FreelancerExperienceInfoController : Controller
    {
        private readonly IFreelancerExperienceInfoService _iFreelancerExperienceInfoService;
        public FreelancerExperienceInfoController(IFreelancerExperienceInfoService iFreelancerExperienceInfoService)
        {
            _iFreelancerExperienceInfoService = iFreelancerExperienceInfoService;
        }
        public ActionResult Index()
        {
            return View(_iFreelancerExperienceInfoService.GetAllByFreelancerId(User.Identity.GetUserId()));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Freelancer_Id,Organization,Designation,Responsibilities,AreaofExperiences,Location,FromDate,ToDate")] FREELANCER_EXPERIENCE_INFO_Model fREELANCER_EXPERIENCE_INFO_Model)
        {
            if (ModelState.IsValid)
            {
                fREELANCER_EXPERIENCE_INFO_Model.Freelancer_Id = User.Identity.GetUserId();
                if (_iFreelancerExperienceInfoService.InsertFreelancerExperience(fREELANCER_EXPERIENCE_INFO_Model)) ;
                {
                    return RedirectToAction("Index");
                }
            }

            return View(fREELANCER_EXPERIENCE_INFO_Model);
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
            FREELANCER_EXPERIENCE_INFO_Model fREELANCER_EXPERIENCE_INFO_Model = _iFreelancerExperienceInfoService.GetById(id);
            if (fREELANCER_EXPERIENCE_INFO_Model == null)
            {
                return HttpNotFound();
            }
            return View(fREELANCER_EXPERIENCE_INFO_Model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Freelancer_Id,Organization,Designation,Responsibilities,AreaofExperiences,Location,FromDate,ToDate")] FREELANCER_EXPERIENCE_INFO_Model fREELANCER_EXPERIENCE_INFO_Model)
        {
            if (ModelState.IsValid)
            {
                fREELANCER_EXPERIENCE_INFO_Model.Freelancer_Id = User.Identity.GetUserId();
                if (_iFreelancerExperienceInfoService.UpdateFreelancerExperience(fREELANCER_EXPERIENCE_INFO_Model))
                {
                    return RedirectToAction("Index");
                }
            }
            return View(fREELANCER_EXPERIENCE_INFO_Model);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FREELANCER_EXPERIENCE_INFO_Model fREELANCER_EXPERIENCE_INFO_Model = _iFreelancerExperienceInfoService.GetById(id);
            if (fREELANCER_EXPERIENCE_INFO_Model == null)
            {
                return HttpNotFound();
            }
            return View(fREELANCER_EXPERIENCE_INFO_Model);
        }

        // POST: FreelancerExperienceInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            _iFreelancerExperienceInfoService.DeleteFreelancerExperience(id);
            return RedirectToAction("Index");
        }

    }
}
