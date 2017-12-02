using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.Models
{
    public class FREELANCER_EDUCATION_INFO_Model
    {
        public int Id { get; set; }
        public string Freelancer_Id { get; set; }
        [Required]
        public string Degree { get; set; }
        [Required]
        public string Institute { get; set; }
        [Required]
        public Nullable<int> Year { get; set; }
        [Required]
        public string Result { get; set; }
        [Required]
        public string Subject { get; set; }
    }
}
