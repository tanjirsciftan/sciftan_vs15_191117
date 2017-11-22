using SCIFTAN.BLL.Models;
using SCIFTAN.DAL.DB.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.IService
{
    public interface ISkillService
    {
        List<SKILL_Model> GetAllSkill();
        SKILL_Model GetSkillById(int? Id);
        bool InsertSkill(SKILL_Model entity);
        bool DeleteSkill(int? Id);
        bool UpdateSkill(SKILL_Model entity);
    }
}
