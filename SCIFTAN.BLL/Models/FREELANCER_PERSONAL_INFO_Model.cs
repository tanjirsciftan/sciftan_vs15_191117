﻿using System;
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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }
        public string NID { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Email { get; set; }
    }
}