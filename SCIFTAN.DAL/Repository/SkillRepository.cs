using SCIFTAN.DAL.DB.EF;
using SCIFTAN.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.DAL.Repository
{
    public class SkillRepository : ISkillRepository
    {
        private SciftanDbContext db = new SciftanDbContext();

        public List<SKILL> GetAll()
        {
            return db.SKILLs.ToList();
        }
        public SKILL GetById(int? Id)
        {
            return db.SKILLs.Where(x => x.Id == Id).SingleOrDefault();
        }

        public bool Insert(SKILL entity)
        {
            db.SKILLs.Add(entity);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int? Id)
        {
            SKILL entity = GetById(Id);
            if (entity != null)
            {
                db.SKILLs.Remove(entity);
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Update(SKILL entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
