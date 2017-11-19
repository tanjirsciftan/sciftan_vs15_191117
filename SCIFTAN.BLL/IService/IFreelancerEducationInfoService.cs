using SCIFTAN.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.IService
{
    public interface IFreelancerEducationInfoService
    {
        List<FREELANCER_EDUCATION_INFO_Model> GetAllByFreelancerId(string freelancerId);
        FREELANCER_EDUCATION_INFO_Model GetById(int? Id);
        bool InsertFreelancerEducation(FREELANCER_EDUCATION_INFO_Model entity);
        bool DeleteFreelancerEducation(int? Id);
        bool UpdateFreelancerEducation(FREELANCER_EDUCATION_INFO_Model entity);
    }
}
