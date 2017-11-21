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
    public class FreelancerExperienceInfoService : IFreelancerExperienceInfoService
    {
        private readonly IFreelancerExperienceInfoRepository _iFreelancerExperienceInfoRepository;

        public FreelancerExperienceInfoService(IFreelancerExperienceInfoRepository iFreelancerExperienceInfoRepository)
        {
            _iFreelancerExperienceInfoRepository = iFreelancerExperienceInfoRepository;
        }
        public List<FREELANCER_EXPERIENCE_INFO_Model> GetAllByFreelancerId(string freelancerId)
        {
            return Mapper.Map<List<FREELANCER_EXPERIENCE_INFO>, List<FREELANCER_EXPERIENCE_INFO_Model>>(_iFreelancerExperienceInfoRepository.GetAllByFreelancerId(freelancerId));
        }

        public FREELANCER_EXPERIENCE_INFO_Model GetById(int? Id)
        {
            return Mapper.Map<FREELANCER_EXPERIENCE_INFO, FREELANCER_EXPERIENCE_INFO_Model>(_iFreelancerExperienceInfoRepository.GetById(Id));
        }

        public bool InsertFreelancerExperience(FREELANCER_EXPERIENCE_INFO_Model entity)
        {
            if (entity != null)
            {
                var data = Mapper.Map<FREELANCER_EXPERIENCE_INFO_Model, FREELANCER_EXPERIENCE_INFO>(entity);
                return _iFreelancerExperienceInfoRepository.Insert(data);
            }
            return false;
        }

        public bool UpdateFreelancerExperience(FREELANCER_EXPERIENCE_INFO_Model entity)
        {
            if (entity != null)
            {
                var data = Mapper.Map<FREELANCER_EXPERIENCE_INFO_Model, FREELANCER_EXPERIENCE_INFO>(entity);
                return _iFreelancerExperienceInfoRepository.Update(data);
            }
            return false;
        }

        public bool DeleteFreelancerExperience(int? Id)
        {
            return _iFreelancerExperienceInfoRepository.Delete(Id);
        }
    }
}
