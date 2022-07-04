using AutoMapper;
using MyAssignment.DbModels;
using MyAssignment.Models;

namespace MyAssignment.Profiles
{
    public class VisitProfileDto : Profile
    {
        public VisitProfileDto()
        {
            CreateMap<VisitDto,Visit>();
            CreateMap<DoctorDto,Doctor>();
            CreateMap<PatientDto,Patient>();
        }
    }
}
