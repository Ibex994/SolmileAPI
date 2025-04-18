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
        }
    }
}
