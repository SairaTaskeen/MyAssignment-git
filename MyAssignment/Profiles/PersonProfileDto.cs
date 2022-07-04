using AutoMapper;
using MyAssignment.DbModels;
using MyAssignment.Models;

namespace MyAssignment.Profiles
{
    public class PersonProfileDto : Profile
    {
        public PersonProfileDto()
        {
            CreateMap<PersonDto,Person>();
            CreateMap<ClinicDto,Clinic>();
            CreateMap<StaffDto,Staff>();
            CreateMap<PatientDto, Patient>();
        }
    }
}
