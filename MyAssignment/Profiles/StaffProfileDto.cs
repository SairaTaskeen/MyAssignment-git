using AutoMapper;
using MyAssignment.DbModels;
using MyAssignment.Models;

namespace MyAssignment.Profiles
{
    public class StaffProfileDto : Profile
    {
        public StaffProfileDto()
        {
            CreateMap<StaffDto,Staff>();
            CreateMap<DoctorDto,Doctor>();
            CreateMap<DeskStaffDto, DeskStaff>();
            CreateMap<PersonDto, Person>();
        }
    }
}
