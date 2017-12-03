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
   [Authorize]
    public class FreelancerSkillInfoController : Controller
    {
        private readonly IFreelancerSkillInfoService _iFreelancerSkillInfoService;
        private readonly ISkillService _iSkillService;
        public FreelancerSkillInfoController(IFreelancerSkillInfoService iFreelancerSkillInfoService, ISkillService iSkillService)
        {
            _iFreelancerSkillInfoService = iFreelancerSkillInfoService;
            _iSkillService = iSkillService;
        }
        public ActionResult Index()
        {
            return View(_iFreelancerSkillInfoService.GetAllByFreelancerId(User.Identity.GetUserId()));
        }

        public ActionResult Create()
        {
            var freelancerSkills = new FREELANCER_SKILL_INFO_Model();
            freelancerSkills.Skills = _iSkillService.GetAllSkill();
            return View(freelancerSkills);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Freelancer_Id,Skill,Description")] FREELANCER_SKILL_INFO_Model fREELANCER_SKILL_INFO_Model)
        {
            if (ModelState.IsValid)
            {
                fREELANCER_SKILL_INFO_Model.Freelancer_Id = User.Identity.GetUserId();
                if (_iFreelancerSkillInfoService.InsertFreelancerSkill(fREELANCER_SKILL_INFO_Model)) ;
                {
                    return RedirectToAction("Index");
                }
            }

            return View(fREELANCER_SKILL_INFO_Model);
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

            FREELANCER_SKILL_INFO_Model fREELANCER_SKILL_INFO_Model = _iFreelancerSkillInfoService.GetById(id);
            fREELANCER_SKILL_INFO_Model.Skills = _iSkillService.GetAllSkill();

            ViewBag.DepartmentId = new SelectList(fREELANCER_SKILL_INFO_Model.Skills, "Id", "Name", fREELANCER_SKILL_INFO_Model.Skill);

            if (fREELANCER_SKILL_INFO_Model == null)
            {
                return HttpNotFound();
            }
            return View(fREELANCER_SKILL_INFO_Model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Freelancer_Id,Skill,Description")] FREELANCER_SKILL_INFO_Model fREELANCER_SKILL_INFO_Model)
        {
            if (ModelState.IsValid)
            {
                fREELANCER_SKILL_INFO_Model.Freelancer_Id = User.Identity.GetUserId();
                if (_iFreelancerSkillInfoService.UpdateFreelancerSkill(fREELANCER_SKILL_INFO_Model))
                {
                    return RedirectToAction("Index");
                }
            }
            return View(fREELANCER_SKILL_INFO_Model);
        }
          
        // GET: FreelancerSkillInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            _iFreelancerSkillInfoService.DeleteFreelancerSkill(id);
            return RedirectToAction("Index");
        }



    }
}
