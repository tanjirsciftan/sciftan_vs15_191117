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
    public class FreelancerCareerObjectiveRepository : IFreelancerCareerObjectiveRepository
    {
        private SciftanDbContext db = new SciftanDbContext();

        public FREELANCER_CAREER_OBJECTIVE GetById(string Id)
        {
            return db.FREELANCER_CAREER_OBJECTIVE.Where(x => x.Freelancer_Id == Id).SingleOrDefault();
        }

        public bool Insert(FREELANCER_CAREER_OBJECTIVE entity)
        {
            db.FREELANCER_CAREER_OBJECTIVE.Add(entity);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(string freelaner_id)
        {
            FREELANCER_CAREER_OBJECTIVE entity = GetById(freelaner_id);
            if (entity != null)
            {
                db.FREELANCER_CAREER_OBJECTIVE.Remove(entity);
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Update(FREELANCER_CAREER_OBJECTIVE entity)
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
