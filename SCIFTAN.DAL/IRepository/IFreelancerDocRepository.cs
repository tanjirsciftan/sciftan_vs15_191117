using SCIFTAN.DAL.DB.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.DAL.IRepository
{
    public interface IFreelancerDocRepository
    {
        FREELANCER_DOC_INFO GetById(string Id);
        bool Insert(FREELANCER_DOC_INFO entity);
        bool Delete(string freelaner_id);
        bool Update(FREELANCER_DOC_INFO entity);
    }
}
