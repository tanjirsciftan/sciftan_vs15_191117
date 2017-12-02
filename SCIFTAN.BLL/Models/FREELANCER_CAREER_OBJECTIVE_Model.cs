using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.Models
{
    public class FREELANCER_CAREER_OBJECTIVE_Model
    {
        [Key]
        public string Freelancer_Id { get; set; }
        [Required]
        [Display(Name = "Career Objective")]
        public string Career_Objective { get; set; }
    }
}
