using SCIFTAN.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.IService
{
    public interface IFreelancerExperienceInfoService
    {
        List<FREELANCER_EXPERIENCE_INFO_Model> GetAllByFreelancerId(string freelancerId);
        FREELANCER_EXPERIENCE_INFO_Model GetById(int? Id);
        bool InsertFreelancerExperience(FREELANCER_EXPERIENCE_INFO_Model entity);
        bool DeleteFreelancerExperience(int? Id);
        bool UpdateFreelancerExperience(FREELANCER_EXPERIENCE_INFO_Model entity);
    }
}
