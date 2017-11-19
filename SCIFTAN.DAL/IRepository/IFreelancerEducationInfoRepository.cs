using SCIFTAN.DAL.DB.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.DAL.IRepository
{
    public interface IFreelancerEducationInfoRepository
    {
        List<FREELANCER_EDUCATION_INFO> GetAllByFreelancerId(string freelancerId);
        FREELANCER_EDUCATION_INFO GetById(int? Id);
        bool Insert(FREELANCER_EDUCATION_INFO entity);
        bool Delete(int? Id);
        bool Update(FREELANCER_EDUCATION_INFO entity);
    }
}
