﻿using SCIFTAN.DAL.DB.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIFTAN.BLL.Models
{
    public class FREELANCER_SKILL_INFO_Model
    {
        public int Id { get; set; }
        public string Freelancer_Id { get; set; }
        public Nullable<int> Skill { get; set; }
        public string Description { get; set; }
        public List<SKILL> Skills { get; set; }
    }
}