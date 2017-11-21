using SCIFTAN.DAL.DB.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.DAL.IRepository
{
    public interface IFreelancerSkillInfoRepository
    {
        List<FREELANCER_SKILL_INFO> GetAllByFreelancerId(string freelancerId);
        FREELANCER_SKILL_INFO GetById(int? Id);
        bool Insert(FREELANCER_SKILL_INFO entity);
        bool Delete(int? Id);
        bool Update(FREELANCER_SKILL_INFO entity);
    }
}
