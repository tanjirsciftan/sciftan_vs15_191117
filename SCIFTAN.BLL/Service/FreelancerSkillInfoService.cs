using AutoMapper;
using SCIFTAN.BLL.IService;
using SCIFTAN.BLL.Models;
using SCIFTAN.DAL.DB.EF;
using SCIFTAN.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.Service
{
    public class FreelancerSkillInfoService : IFreelancerSkillInfoService
    {

        private readonly IFreelancerSkillInfoRepository _iFreelancerSkillInfoRepository;
        private readonly ISkillService _iSkillService;
        public FreelancerSkillInfoService(IFreelancerSkillInfoRepository iFreelancerSkillInfoRepository, ISkillService iSkillService)
        {
            _iFreelancerSkillInfoRepository = iFreelancerSkillInfoRepository;
            _iSkillService = iSkillService;
        }
        public List<FREELANCER_SKILL_INFO_Model> GetAllByFreelancerId(string freelancerId)
        {
            var freelancerSkills = _iFreelancerSkillInfoRepository.GetAllByFreelancerId(freelancerId);
            List<FREELANCER_SKILL_INFO_Model> skillModelList = new List<FREELANCER_SKILL_INFO_Model>();

            foreach (var skill in freelancerSkills)
            {
                skillModelList.Add(new FREELANCER_SKILL_INFO_Model
                {
                    Id = skill.Id,
                    SkillName = _iSkillService.GetSkillById(skill.Skill).Name.ToString(),
                    Description = skill.Description
                });
            }

            return skillModelList;
        }

        public FREELANCER_SKILL_INFO_Model GetById(int? Id)
        {
            var freelancerSkill = _iFreelancerSkillInfoRepository.GetById(Id);

            var freelancerSkillModel = new FREELANCER_SKILL_INFO_Model{
                Id = freelancerSkill.Id,
                SkillName = _iSkillService.GetSkillById(freelancerSkill.Skill).Name.ToString(),
                Description =freelancerSkill.Description
            };

            return freelancerSkillModel;
        }

        public bool InsertFreelancerSkill(FREELANCER_SKILL_INFO_Model entity)
        {
            if (entity != null)
            {
                var data = Mapper.Map<FREELANCER_SKILL_INFO_Model, FREELANCER_SKILL_INFO>(entity);
                return _iFreelancerSkillInfoRepository.Insert(data);
            }
            return false;
        }

        public bool UpdateFreelancerSkill(FREELANCER_SKILL_INFO_Model entity)
        {
            if (entity != null)
            {
                var data = Mapper.Map<FREELANCER_SKILL_INFO_Model, FREELANCER_SKILL_INFO>(entity);
                return _iFreelancerSkillInfoRepository.Update(data);
            }
            return false;
        }

        public bool DeleteFreelancerSkill(int? Id)
        {
            return _iFreelancerSkillInfoRepository.Delete(Id);
        }
    }
}
