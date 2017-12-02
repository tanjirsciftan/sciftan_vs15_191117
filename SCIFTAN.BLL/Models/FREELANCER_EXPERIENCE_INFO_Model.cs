using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.Models
{
    public class FREELANCER_EXPERIENCE_INFO_Model
    {
        public int Id { get; set; }
        public string Freelancer_Id { get; set; }
        [Required]
        public string Organization { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public string Responsibilities { get; set; }
        [Required]
        [Display(Name = "Area of Experience")]
        public string AreaofExperiences { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        [Display(Name = "From Date")]
        public Nullable<System.DateTime> FromDate { get; set; }
        [Required]
        [Display(Name = "To Date")]
        public Nullable<System.DateTime> ToDate { get; set; }
    }
}
