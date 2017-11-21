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

        public FreelancerSkillInfoService(IFreelancerSkillInfoRepository iFreelancerSkillInfoRepository)
        {
            _iFreelancerSkillInfoRepository = iFreelancerSkillInfoRepository;
        }
        public List<FREELANCER_SKILL_INFO_Model> GetAllByFreelancerId(string freelancerId)
        {
            return Mapper.Map<List<FREELANCER_SKILL_INFO>, List<FREELANCER_SKILL_INFO_Model>>(_iFreelancerSkillInfoRepository.GetAllByFreelancerId(freelancerId));
        }

        public FREELANCER_SKILL_INFO_Model GetById(int? Id)
        {
            return Mapper.Map<FREELANCER_SKILL_INFO, FREELANCER_SKILL_INFO_Model>(_iFreelancerSkillInfoRepository.GetById(Id));
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
