using SCIFTAN.DAL.DB.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.DAL.IRepository
{
    public interface IFreelancerExperienceInfoRepository
    {
        List<FREELANCER_EXPERIENCE_INFO> GetAllByFreelancerId(string freelancerId);
        FREELANCER_EXPERIENCE_INFO GetById(int? Id);
        bool Insert(FREELANCER_EXPERIENCE_INFO entity);
        bool Delete(int? Id);
        bool Update(FREELANCER_EXPERIENCE_INFO entity);
    }
}
