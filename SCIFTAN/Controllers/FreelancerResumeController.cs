using Microsoft.AspNet.Identity;
using SCIFTAN.BLL.IService;
using SCIFTAN.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCIFTAN.Controllers
{
    [Authorize]
    public class FreelancerResumeController : Controller
    {
        private readonly IFreelancerCareerObjectiveService _iFreelancerCareerObjectiveService;
        private readonly IFreelancerDocService _iFreelancerDocService;
        private readonly IFreelancerEducationInfoService _iFreelancerEducationInfoService;
        private readonly IFreelancerExperienceInfoService _iFreelancerExperienceInfoService;
        private readonly IFreelancerPersonalInfoService _iFreelancerPersonalInfoService;
        private readonly IFreelancerSkillInfoService _iFreelancerSkillInfoService;


        public FreelancerResumeController(IFreelancerCareerObjectiveService iFreelancerCareerObjectiveService,
                                        IFreelancerDocService iFreelancerDocService,
                                        IFreelancerEducationInfoService iFreelancerEducationInfoService,
                                        IFreelancerExperienceInfoService iFreelancerExperienceInfoService,
                                        IFreelancerPersonalInfoService iFreelancerPersonalInfoService,
                                        IFreelancerSkillInfoService iFreelancerSkillInfoService
                                        )
        {
            _iFreelancerCareerObjectiveService = iFreelancerCareerObjectiveService;
            _iFreelancerDocService = iFreelancerDocService;
            _iFreelancerEducationInfoService = iFreelancerEducationInfoService;
            _iFreelancerExperienceInfoService = iFreelancerExperienceInfoService;
            _iFreelancerPersonalInfoService = iFreelancerPersonalInfoService;
            _iFreelancerSkillInfoService = iFreelancerSkillInfoService;
        }


        public ActionResult Index()
        {
            FREELANCER_RESUME_Model resume = new FREELANCER_RESUME_Model();

            string userId = User.Identity.GetUserId();

            resume.PersonalInfo = _iFreelancerPersonalInfoService.GetFreelancerPersonalInfoById(userId);
            resume.Educations = _iFreelancerEducationInfoService.GetAllByFreelancerId(userId);
            resume.Experiences = _iFreelancerExperienceInfoService.GetAllByFreelancerId(userId);
            resume.Skills = _iFreelancerSkillInfoService.GetAllByFreelancerId(userId);
            resume.CareerObjective = _iFreelancerCareerObjectiveService.GetFreelancerCareerObjectiveById(userId);
            resume.Docs = _iFreelancerDocService.GetFreelancerDocById(userId);

            return View(resume);
        }
    }
}