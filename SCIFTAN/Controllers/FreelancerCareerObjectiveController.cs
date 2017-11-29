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
    public class FreelancerCareerObjectiveController : Controller
    {
        private readonly IFreelancerCareerObjectiveService _iFreelancerCareerObjectiveService;

        public FreelancerCareerObjectiveController(IFreelancerCareerObjectiveService iFreelancerCareerObjectiveService)
        {
            _iFreelancerCareerObjectiveService = iFreelancerCareerObjectiveService;
        }
        public ActionResult Index()
        {
            FREELANCER_CAREER_OBJECTIVE_Model careerObjective = null;
            if (User.Identity.GetUserId() != null)
            {
                careerObjective = _iFreelancerCareerObjectiveService.GetFreelancerCareerObjectiveById(User.Identity.GetUserId());
            }
            return View(careerObjective);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Freelancer_Id,Career_Objective")] FREELANCER_CAREER_OBJECTIVE_Model fREELANCER_CAREER_OBJECTIVE_Model)
        {
            if (ModelState.IsValid)
            {
                fREELANCER_CAREER_OBJECTIVE_Model.Freelancer_Id = User.Identity.GetUserId();
                if (_iFreelancerCareerObjectiveService.InsertFreelancerCareerObjective(fREELANCER_CAREER_OBJECTIVE_Model)) ;
                {
                    return RedirectToAction("Index");
                }
            }

            return View(fREELANCER_CAREER_OBJECTIVE_Model);
        }

        public ActionResult Edit(string id)
        {
            if (User.Identity.GetUserId() == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FREELANCER_CAREER_OBJECTIVE_Model fREELANCER_CAREER_OBJECTIVE_Model = _iFreelancerCareerObjectiveService.GetFreelancerCareerObjectiveById(User.Identity.GetUserId());
            if (fREELANCER_CAREER_OBJECTIVE_Model == null)
            {
                return HttpNotFound();
            }
            return View(fREELANCER_CAREER_OBJECTIVE_Model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Freelancer_Id,Career_Objective")] FREELANCER_CAREER_OBJECTIVE_Model fREELANCER_CAREER_OBJECTIVE_Model)
        {
            if (ModelState.IsValid)
            {
                if (_iFreelancerCareerObjectiveService.UpdateFreelancerCareerObjective(fREELANCER_CAREER_OBJECTIVE_Model))
                {
                    return RedirectToAction("Index");
                }
            }
            return View(fREELANCER_CAREER_OBJECTIVE_Model);
        }


    }
}
