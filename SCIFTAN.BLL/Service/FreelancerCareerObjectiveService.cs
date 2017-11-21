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
    public class FreelancerCareerObjectiveService : IFreelancerCareerObjectiveService
    {
        private readonly IFreelancerCareerObjectiveRepository _iFreelancerCareerObjectiveRepository;

        public FreelancerCareerObjectiveService(IFreelancerCareerObjectiveRepository iFreelancerCareerObjectiveRepository)
        {
            _iFreelancerCareerObjectiveRepository = iFreelancerCareerObjectiveRepository;
        }

        public FREELANCER_CAREER_OBJECTIVE_Model GetFreelancerCareerObjectiveById(string Id)
        {
            return Mapper.Map<FREELANCER_CAREER_OBJECTIVE, FREELANCER_CAREER_OBJECTIVE_Model>(_iFreelancerCareerObjectiveRepository.GetById(Id));
        }

        public bool InsertFreelancerCareerObjective(FREELANCER_CAREER_OBJECTIVE_Model entity)
        {
            if (entity != null)
            {
                var data = Mapper.Map<FREELANCER_CAREER_OBJECTIVE_Model, FREELANCER_CAREER_OBJECTIVE>(entity);
                return _iFreelancerCareerObjectiveRepository.Insert(data);
            }
            return false;
        }

        public bool DeleteFreelancerCareerObjective(string freelaner_id)
        {
            return _iFreelancerCareerObjectiveRepository.Delete(freelaner_id);
        }

        public bool UpdateFreelancerCareerObjective(FREELANCER_CAREER_OBJECTIVE_Model entity)
        {
            if (entity != null)
            {
                var data = Mapper.Map<FREELANCER_CAREER_OBJECTIVE_Model, FREELANCER_CAREER_OBJECTIVE>(entity);
                return _iFreelancerCareerObjectiveRepository.Update(data);

            }
            return false;
        }
    }
}
