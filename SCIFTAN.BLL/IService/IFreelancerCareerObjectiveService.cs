using SCIFTAN.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.IService
{
    public interface IFreelancerCareerObjectiveService
    {
        FREELANCER_CAREER_OBJECTIVE_Model GetFreelancerCareerObjectiveById(string Id);
        bool InsertFreelancerCareerObjective(FREELANCER_CAREER_OBJECTIVE_Model entity);
        bool DeleteFreelancerCareerObjective(string freelaner_id);
        bool UpdateFreelancerCareerObjective(FREELANCER_CAREER_OBJECTIVE_Model entity);
    }
}
