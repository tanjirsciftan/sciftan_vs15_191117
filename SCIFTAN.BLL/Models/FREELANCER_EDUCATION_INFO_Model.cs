using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.Models
{
    public class FREELANCER_EDUCATION_INFO_Model
    {
        public int Id { get; set; }
        public string Freelancer_Id { get; set; }
        public string Degree { get; set; }
        public string Institute { get; set; }
        public Nullable<int> Year { get; set; }
        public string Result { get; set; }
        public string Subject { get; set; }
    }
}
