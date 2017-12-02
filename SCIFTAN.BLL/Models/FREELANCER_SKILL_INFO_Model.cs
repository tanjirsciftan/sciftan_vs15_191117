using SCIFTAN.DAL.DB.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.Models
{
    public class FREELANCER_SKILL_INFO_Model
    {
        public int Id { get; set; }
        public string Freelancer_Id { get; set; }
        [Required]
        public Nullable<int> Skill { get; set; }
        [Required]
        public string Description { get; set; }
        public string SkillName { get; set; }
        public List<SKILL_Model> Skills { get; set; }
    }
}
