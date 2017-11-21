using SCIFTAN.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.IService
{
    public interface IFreelancerSkillInfoService
    {
        List<FREELANCER_SKILL_INFO_Model> GetAllByFreelancerId(string freelancerId);
        FREELANCER_SKILL_INFO_Model GetById(int? Id);
        bool InsertFreelancerSkill(FREELANCER_SKILL_INFO_Model entity);
        bool DeleteFreelancerSkill(int? Id);
        bool UpdateFreelancerSkill(FREELANCER_SKILL_INFO_Model entity);
    }
}
