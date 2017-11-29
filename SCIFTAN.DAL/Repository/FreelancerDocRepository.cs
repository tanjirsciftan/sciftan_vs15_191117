using SCIFTAN.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIFTAN.DAL.DB.EF;
using System.Data.Entity;

namespace SCIFTAN.DAL.Repository
{
    public class FreelancerDocRepository : IFreelancerDocRepository
    {
        private SciftanDbContext db = new SciftanDbContext();

        public FREELANCER_DOC_INFO GetById(string Id)
        {
            return db.FREELANCER_DOC_INFO.Where(x => x.Freelancer_Id == Id).SingleOrDefault();
        }

        public bool Insert(FREELANCER_DOC_INFO entity)
        {
            db.FREELANCER_DOC_INFO.Add(entity);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(string freelaner_id)
        {
            FREELANCER_DOC_INFO entity = GetById(freelaner_id);
            if (entity != null)
            {
                db.FREELANCER_DOC_INFO.Remove(entity);
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Update(FREELANCER_DOC_INFO entity)
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
