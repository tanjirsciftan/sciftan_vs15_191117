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
    public class FreelancerDocService : IFreelancerDocService
    {
        private readonly IFreelancerDocRepository _iFreelancerDocRepository;

        public FreelancerDocService(IFreelancerDocRepository iFreelancerDocRepository)
        {
            _iFreelancerDocRepository = iFreelancerDocRepository;
        }

        public FREELANCER_DOC_INFO_Model GetFreelancerDocById(string Id)
        {
            return Mapper.Map<FREELANCER_DOC_INFO, FREELANCER_DOC_INFO_Model>(_iFreelancerDocRepository.GetById(Id));
        }

        public bool InsertFreelancerDoc(FREELANCER_DOC_INFO_Model entity)
        {
            if (entity != null)
            {
                var data = Mapper.Map<FREELANCER_DOC_INFO_Model, FREELANCER_DOC_INFO>(entity);
                return _iFreelancerDocRepository.Insert(data);
            }
            return false;
        }

        public bool DeleteFreelancerDoc(string freelaner_id)
        {
            return _iFreelancerDocRepository.Delete(freelaner_id);
        }

        public bool UpdateFreelancerDoc(FREELANCER_DOC_INFO_Model entity)
        {
            if (entity != null)
            {
                var data = Mapper.Map<FREELANCER_DOC_INFO_Model, FREELANCER_DOC_INFO>(entity);
                return _iFreelancerDocRepository.Update(data);

            }
            return false;
        }
    }
}
