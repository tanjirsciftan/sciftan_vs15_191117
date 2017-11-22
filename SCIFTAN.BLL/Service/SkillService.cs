using SCIFTAN.BLL.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIFTAN.DAL.DB.EF;
using SCIFTAN.DAL.IRepository;
using SCIFTAN.BLL.Models;
using AutoMapper;

namespace SCIFTAN.BLL.Service
{
    public class SkillService : ISkillService
    {
        private readonly ISkillRepository _iSkillRepository;
        public SkillService(ISkillRepository iSkillRepository)
        {
            _iSkillRepository = iSkillRepository;
        }

        public List<SKILL_Model> GetAllSkill()
        {
            return Mapper.Map<List<SKILL>, List<SKILL_Model>>(_iSkillRepository.GetAll());
        }
        public SKILL_Model GetSkillById(int? Id)
        {
            return Mapper.Map<SKILL, SKILL_Model>(_iSkillRepository.GetById(Id));
        }

        public bool InsertSkill(SKILL_Model entity)
        {
            if (entity != null)
            {
                var data = Mapper.Map<SKILL_Model, SKILL>(entity);
                return _iSkillRepository.Insert(data);
            }
            return false;
        }

        public bool UpdateSkill(SKILL_Model entity)
        {
            if (entity != null)
            {
                var data = Mapper.Map<SKILL_Model, SKILL>(entity);
                return _iSkillRepository.Update(data);

            }
            return false;
        }

        public bool DeleteSkill(int? Id)
        {
            return _iSkillRepository.Delete(Id);
        }
    }
}
