using AutoMapper;
using Solmile.Models;
using SolmileAPI.DTO;
using SolmileAPI.Models;

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
            CreateMap<UpdateDto, Employee>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<UpdateCust,Customer>();
        }
    }
}
