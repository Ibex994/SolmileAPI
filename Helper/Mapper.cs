using AutoMapper;
using Solmile.Models;
using SolmileAPI.DTO;
using SolmileAPI.Models;
using static SolmileAPI.DTO.ComplaintDto;

namespace SolmileAPI.Helper
{
    public class Mapper :Profile
    {
        public Mapper()
        {
            //user Dto
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            //Employe Dto
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
            CreateMap<Employee, GetEmployeeDto>();
            CreateMap<UpdateDto, Employee>();
            //Customer Dto
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<UpdateCust,Customer>();
            //Complaint Dto
            CreateMap<Complaint, ComplaintDto>();
            CreateMap<ComplaintDto, Complaint>();
            CreateMap<Complaint, UpdateCompDto>();
            //Reservation Dto
            CreateMap<Reservation, ReservationDto>();
            CreateMap<ReservationDto, Reservation>();
            CreateMap<CreateResDto, Reservation>();
            CreateMap<Reservation, CreateResDto>();
            //Room Dto
            CreateMap<Room, RoomDto>();
            CreateMap<RoomDto, Room>();
            CreateMap<Room, CreateRoomDto>();
            CreateMap<CreateRoomDto, Room>();
            //Branch Dto
            CreateMap<Branch, BranchDto>();
            CreateMap<BranchDto, Branch>();
            CreateMap<Branch, CreateBranchDto>();
            CreateMap<CreateBranchDto, Branch>();
            CreateMap<Branch, UpdateBranchDto>();
            CreateMap<UpdateBranchDto, Branch>();
            //ContactDetailsDto
            CreateMap<ContactDetail, ContactDetailDto>();
            CreateMap<ContactDetailDto, ContactDetail>();
            CreateMap<ContactDetail, CreateConDetDto>();
            CreateMap<CreateConDetDto, ContactDetail>();
        }
    }
}
