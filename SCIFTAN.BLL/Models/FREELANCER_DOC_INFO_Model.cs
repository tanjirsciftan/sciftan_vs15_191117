using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.Models
{
    public class FREELANCER_DOC_INFO_Model
    {
        [Key]
        public string Freelancer_Id { get; set; }
        public string NID_Path { get; set; }
        public string Picture_Path { get; set; }
        public string PVC_Path { get; set; }
    }
}
