using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.Models
{
    public class FREELANCER_EXPERIENCE_INFO_Model
    {
        public int Id { get; set; }
        public string Freelancer_Id { get; set; }
        public string Organization { get; set; }
        public string Designation { get; set; }
        public string Responsibilities { get; set; }
        public string AreaofExperiences { get; set; }
        public string Location { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
    }
}
