using SCIFTAN.DAL.DB.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.DAL.IRepository
{
    public interface ISkillRepository
    {
        List<SKILL> GetAll();
        SKILL GetById(int? Id);
        bool Insert(SKILL entity);
        bool Delete(int? Id);
        bool Update(SKILL entity);
    }
}
