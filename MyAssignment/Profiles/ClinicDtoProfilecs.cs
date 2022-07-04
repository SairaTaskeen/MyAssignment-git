using AutoMapper;
using MyAssignment.DbModels;
using MyAssignment.Models;

namespace MyAssignment.Profiles
{
    public class ClinicDtoProfilecs : Profile
    {
        //from source to destination mapping
        public ClinicDtoProfilecs()
        {
            //create map will take a source inside anglebrackets 
            CreateMap<ClinicDto, Clinic>();
            CreateMap<PersonDto, Person>();
        }
    }
}
