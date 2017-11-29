using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.Models
{
    public class FREELANCER_RESUME_Model
    {
        public FREELANCER_PERSONAL_INFO_Model PersonalInfo { get; set; }
        public FREELANCER_CAREER_OBJECTIVE_Model CareerObjective { get; set; }
        public List<FREELANCER_EDUCATION_INFO_Model> Educations { get; set; }
        public List<FREELANCER_EXPERIENCE_INFO_Model> Experiences { get; set; }
        public List<FREELANCER_SKILL_INFO_Model> Skills { get; set; }
        public FREELANCER_DOC_INFO_Model Docs { get; set; }
    }
}
