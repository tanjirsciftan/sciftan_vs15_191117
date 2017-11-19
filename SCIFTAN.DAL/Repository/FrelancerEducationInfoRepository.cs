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
    public class FrelancerEducationInfoRepository : IFreelancerEducationInfoRepository
    {
        private SciftanDbContext db = new SciftanDbContext();
        public List<FREELANCER_EDUCATION_INFO> GetAllByFreelancerId(string freelancerId)
        {
            return db.FREELANCER_EDUCATION_INFO.Where(x => x.Freelancer_Id == freelancerId).ToList();
        }

        public FREELANCER_EDUCATION_INFO GetById(int? Id)
        {
            return db.FREELANCER_EDUCATION_INFO.Where(x => x.Id == Id).FirstOrDefault();
        }

        public bool Insert(FREELANCER_EDUCATION_INFO entity)
        {
            db.FREELANCER_EDUCATION_INFO.Add(entity);
            if(db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool Update(FREELANCER_EDUCATION_INFO entity)
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
            FREELANCER_EDUCATION_INFO entity = GetById(Id);
            if (entity != null)
            {
                db.FREELANCER_EDUCATION_INFO.Remove(entity);
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
