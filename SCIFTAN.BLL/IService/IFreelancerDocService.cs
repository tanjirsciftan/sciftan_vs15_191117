using SCIFTAN.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.IService
{
    public interface IFreelancerDocService
    {
        FREELANCER_DOC_INFO_Model GetFreelancerDocById(string Id);
        bool InsertFreelancerDoc(FREELANCER_DOC_INFO_Model entity);
        bool DeleteFreelancerDoc(string freelaner_id);
        bool UpdateFreelancerDoc(FREELANCER_DOC_INFO_Model entity);
    }
}
