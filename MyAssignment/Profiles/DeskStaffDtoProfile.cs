using AutoMapper;
using MyAssignment.DbModels;
using MyAssignment.Models;

namespace MyAssignment.Profiles
{
    public class DeskStaffDtoProfile:Profile
    {
        public DeskStaffDtoProfile()
        {
            CreateMap<DeskStaffDto,DeskStaff>();
            CreateMap<StaffDto, Staff>();
        }
    }
}
