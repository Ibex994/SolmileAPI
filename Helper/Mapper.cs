using AutoMapper;
using Solmile.Models;
using SolmileAPI.DTO;

namespace SolmileAPI.Helper
{
    public class Mapper :Profile
    {
        public Mapper()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
        }
    }
}
