using SCIFTAN.DAL.DB.EF;
using SCIFTAN.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.DAL.Repository
{
    public class FrelancerExperienceInfoRepository : IFreelancerExperienceInfoRepository
    {
        private SciftanDbContext db = new SciftanDbContext();
        public List<FREELANCER_EXPERIENCE_INFO> GetAllByFreelancerId(string freelancerId)
        {
            return db.FREELANCER_EXPERIENCE_INFO.Where(x => x.Freelancer_Id == freelancerId).ToList();
        }

        public FREELANCER_EXPERIENCE_INFO GetById(int? Id)
        {
            return db.FREELANCER_EXPERIENCE_INFO.Where(x => x.Id == Id).FirstOrDefault();
        }

        public bool Insert(FREELANCER_EXPERIENCE_INFO entity)
        {
            db.FREELANCER_EXPERIENCE_INFO.Add(entity);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool Update(FREELANCER_EXPERIENCE_INFO entity)
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
            FREELANCER_EXPERIENCE_INFO entity = GetById(Id);
            if (entity != null)
            {
                db.FREELANCER_EXPERIENCE_INFO.Remove(entity);
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
