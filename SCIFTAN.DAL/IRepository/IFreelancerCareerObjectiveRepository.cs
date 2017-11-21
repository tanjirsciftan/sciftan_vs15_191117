using SCIFTAN.DAL.DB.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.DAL.IRepository
{
    public interface IFreelancerCareerObjectiveRepository
    {
        FREELANCER_CAREER_OBJECTIVE GetById(string Id);
        bool Insert(FREELANCER_CAREER_OBJECTIVE entity);
        bool Delete(string freelaner_id);
        bool Update(FREELANCER_CAREER_OBJECTIVE entity);
    }
}
