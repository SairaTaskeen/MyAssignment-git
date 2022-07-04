using AutoMapper;
using MyAssignment.DbModels;
using MyAssignment.Models;

namespace MyAssignment.Profiles
{
    public class PatientDtoProfile : Profile
    {
        public PatientDtoProfile()
        {
            CreateMap<PatientDto,Patient>();
            CreateMap<VisitDto,Visit>();
            CreateMap<PersonDto,Person>();
        }
    }
}
