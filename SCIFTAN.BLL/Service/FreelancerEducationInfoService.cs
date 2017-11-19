using SCIFTAN.BLL.IService;
using System.Collections.Generic;
using SCIFTAN.BLL.Models;
using SCIFTAN.DAL.IRepository;
using AutoMapper;
using SCIFTAN.DAL.DB.EF;

namespace SCIFTAN.BLL.Service
{
    public class FreelancerEducationInfoService : IFreelancerEducationInfoService
    {
        private readonly IFreelancerEducationInfoRepository _iFreelancerEducationInfoRepository;

        public FreelancerEducationInfoService(IFreelancerEducationInfoRepository iFreelancerEducationInfoRepository)
        {
            _iFreelancerEducationInfoRepository = iFreelancerEducationInfoRepository;
        }
        public List<FREELANCER_EDUCATION_INFO_Model> GetAllByFreelancerId(string freelancerId)
        {
            return Mapper.Map<List<FREELANCER_EDUCATION_INFO>, List<FREELANCER_EDUCATION_INFO_Model>>(_iFreelancerEducationInfoRepository.GetAllByFreelancerId(freelancerId));
        }

        public FREELANCER_EDUCATION_INFO_Model GetById(int? Id)
        {
            return Mapper.Map<FREELANCER_EDUCATION_INFO, FREELANCER_EDUCATION_INFO_Model>(_iFreelancerEducationInfoRepository.GetById(Id));
        }

        public bool InsertFreelancerEducation(FREELANCER_EDUCATION_INFO_Model entity)
        {
            if (entity != null)
            {
                var data = Mapper.Map<FREELANCER_EDUCATION_INFO_Model, FREELANCER_EDUCATION_INFO>(entity);
                return _iFreelancerEducationInfoRepository.Insert(data);
            }
            return false;
        }

        public bool UpdateFreelancerEducation(FREELANCER_EDUCATION_INFO_Model entity)
        {
            if (entity != null)
            {
                var data = Mapper.Map<FREELANCER_EDUCATION_INFO_Model, FREELANCER_EDUCATION_INFO>(entity);
                return _iFreelancerEducationInfoRepository.Update(data);
            }
            return false;
        }

        public bool DeleteFreelancerEducation(int? Id)
        {
            return _iFreelancerEducationInfoRepository.Delete(Id);
        }
    }
}
