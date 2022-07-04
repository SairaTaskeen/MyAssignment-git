using AutoMapper;
using MyAssignment.DbModels;
using MyAssignment.Models;

namespace MyAssignment.Profiles
{
    public class DoctorDtoProfile : Profile
    {
        public DoctorDtoProfile()
        {
            CreateMap<DoctorDto, Doctor>();
            CreateMap<StaffDto, Staff>();
            CreateMap<VisitDto, Visit>();
        }
    }
}
