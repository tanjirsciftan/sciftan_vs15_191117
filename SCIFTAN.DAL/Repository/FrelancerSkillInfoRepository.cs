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
    public class FrelancerSkillInfoRepository : IFreelancerSkillInfoRepository
    {
        private SciftanDbContext db = new SciftanDbContext();
        public List<FREELANCER_SKILL_INFO> GetAllByFreelancerId(string freelancerId)
        {
            return db.FREELANCER_SKILL_INFO.Where(x => x.Freelancer_Id == freelancerId).ToList();
        }

        public FREELANCER_SKILL_INFO GetById(int? Id)
        {
            return db.FREELANCER_SKILL_INFO.Where(x => x.Id == Id).FirstOrDefault();
        }

        public bool Insert(FREELANCER_SKILL_INFO entity)
        {
            db.FREELANCER_SKILL_INFO.Add(entity);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool Update(FREELANCER_SKILL_INFO entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
        public bool Delete(int? Id)
        {
            FREELANCER_SKILL_INFO entity = GetById(Id);
            if (entity != null)
            {
                db.FREELANCER_SKILL_INFO.Remove(entity);
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
