using AutoMapper;
using Solmile.DTO;
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
            CreateMap<Room, RoomDto>()
                    .ForMember(dest => dest.RoomTypeName, opt => opt.MapFrom(src => src.RoomTypes.TypeName)); 
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
            //AttendanceDto
            CreateMap<EmployeeAttendanceDto, EmployeeAttendance>();
            CreateMap<EmployeeAttendanceDto, Attendance>();
            CreateMap<Attendance, EmployeeAttendanceDto>();
            CreateMap<EmployeeAttendance, EmployeeAttendanceDto>();
            CreateMap<Attendance, AttendanceCreateDto>();
            CreateMap<AttendanceCreateDto, Attendance>();
            CreateMap<UpdateEmployeeAttendanceDto, EmployeeAttendance>();
            CreateMap<EmployeeAttendance, UpdateEmployeeAttendanceDto>();
            //LogDto
            CreateMap<Log, LogDto>();
            CreateMap<LogDto, Log>();
            CreateMap<Log, LoginDto>();
            CreateMap<LoginDto, Log>();
            //EmployeeTask
            CreateMap<EmployeeTask, EmployeeTaskDto>();
            CreateMap<EmployeeTaskDto, EmployeeTask>();
            CreateMap<EmployeeTask, AssignTaskDto>();
            CreateMap<AssignTaskDto, EmployeeTask>();
            CreateMap<EmployeeTask, EmpTaskDto>()
                 .ForMember(dest => dest.EmployeeName,
                opt => opt.MapFrom(src =>
                    src.Employee != null
                        ? $"{src.Employee.FirstName} {src.Employee.LastName}"
                        : null));
            CreateMap<EmpTaskDto, EmployeeTask>();
            CreateMap<EmployeeTask, CreateEmployeeTaskDto>();
            CreateMap<CreateEmployeeTaskDto, EmployeeTask>();
            //FeedBack
            CreateMap<FeedBack, FeedbackDto>();
            CreateMap<FeedbackDto, FeedBack>();
            CreateMap<CreateFeedbackDto, FeedBack>();
            CreateMap<FeedBack, CreateFeedbackDto>();

        }
    }
}
