using AutoMapper;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.ComplaintDto;

namespace SolmileGuesthouseAPI.Helper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            
            //Complaint Dto
            CreateMap<Complaint, ComplaintDto>();
            CreateMap<ComplaintDto, Complaint>();
            CreateMap<Complaint, UpdateCompDto>();

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
           
            //FeedBack
            CreateMap<FeedBack, FeedbackDto>();
            CreateMap<FeedbackDto, FeedBack>();
            CreateMap<CreateFeedbackDto, FeedBack>();
            CreateMap<FeedBack, CreateFeedbackDto>();

        }
    }
}
