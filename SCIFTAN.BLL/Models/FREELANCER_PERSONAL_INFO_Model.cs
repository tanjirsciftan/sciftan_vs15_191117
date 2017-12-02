using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.Models
{
    public class FREELANCER_PERSONAL_INFO_Model
    {
        [Key]
        public string Freelancer_Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Father's Name")]
        public string FatherName { get; set; }
        [Required]
        [Display(Name = "Mother's Name")]
        public string MotherName { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        public string DOB { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Religion { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string MaritalStatus { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string Nationality { get; set; }
        public string NID { get; set; }
        [Required]
        [Display(Name = "Present Address")]
        public string PresentAddress { get; set; }
        [Required]
        [Display(Name = "Permanent Address")]
        public string PermanentAddress { get; set; }
        [Required]
        [Display(Name = "Mobile 1")]
        public string Mobile1 { get; set; }
        [Display(Name = "Mobile 2")]
        public string Mobile2 { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
