using AutoMapper;
using SCIFTAN.BLL.Models;
using SCIFTAN.DAL.DB.EF;

namespace SCIFTAN.BLL.ModelMapping
{
    public partial class DomainToDatabaseProfile : Profile
    {
        protected override void Configure()
        {

            CreateMap<FREELANCER_PERSONAL_INFO_Model, FREELANCER_PERSONAL_INFO>();
            CreateMap<FREELANCER_EDUCATION_INFO_Model, FREELANCER_EDUCATION_INFO>();
            CreateMap<FREELANCER_EXPERIENCE_INFO_Model, FREELANCER_EXPERIENCE_INFO>();
            CreateMap<FREELANCER_SKILL_INFO_Model, FREELANCER_SKILL_INFO>();
            CreateMap<FREELANCER_CAREER_OBJECTIVE_Model, FREELANCER_CAREER_OBJECTIVE>();
            CreateMap<FREELANCER_DOC_INFO_Model, FREELANCER_DOC_INFO>();
            CreateMap<SKILL_Model, SKILL>();
        }
    }
}


