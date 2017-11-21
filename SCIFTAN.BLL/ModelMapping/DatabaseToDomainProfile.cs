using AutoMapper;
using SCIFTAN.BLL.Models;
using SCIFTAN.DAL.DB.EF;

namespace SCIFTAN.BLL.ModelMapping
{
    public partial class DatabaseToDomainProfile : Profile
    {
        protected override void Configure()
        {            
            CreateMap<FREELANCER_PERSONAL_INFO, FREELANCER_PERSONAL_INFO_Model>();
            CreateMap<FREELANCER_EDUCATION_INFO, FREELANCER_EDUCATION_INFO_Model>();
            CreateMap<FREELANCER_EXPERIENCE_INFO, FREELANCER_EXPERIENCE_INFO_Model>();
            CreateMap<FREELANCER_SKILL_INFO, FREELANCER_SKILL_INFO_Model>();
            CreateMap<FREELANCER_CAREER_OBJECTIVE, FREELANCER_CAREER_OBJECTIVE_Model>();
        }
    }
}

