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
           
            //FeedBackDto
            CreateMap<FeedBack, FeedbackDto>();
            CreateMap<FeedbackDto, FeedBack>();
            CreateMap<CreateFeedbackDto, FeedBack>();
            CreateMap<FeedBack, CreateFeedbackDto>();

            //PayrollDto
            CreateMap<Payroll, PayrollDto>();
            CreateMap<PayrollDto, Payroll>();
            CreateMap<PayrollCreateDto, Payroll>();
            CreateMap<Payroll, PayrollResponseDto>();
            CreateMap<PayrollResponseDto, Payroll>();
            CreateMap<Payroll, PayrollCreateDto>();
            CreateMap<Payroll, DeductionRequestDto>();
            CreateMap<DeductionRequestDto, Payroll>();

            //TaxDto
            CreateMap<Tax, TaxDto>();
            CreateMap<TaxDto, Tax>();
            CreateMap<Tax, CreateTaxDto>();
            CreateMap<CreateTaxDto, Tax>();
            CreateMap<Tax, UpdateTaxDto>();
            CreateMap<UpdateTaxDto, Tax>();

            //PaymentDto
            CreateMap<Payment, PaymentDto>();
            CreateMap<PaymentDto, Payment>();
            CreateMap<CreatePaymentDto, Payment>();
            CreateMap<Payment, CreatePaymentDto>();
            CreateMap<Payment, UpdatePaymentDto>();
            CreateMap<UpdatePaymentDto, Payment>();
            CreateMap<Payment, ProcessPaymentDto>();
            CreateMap<ProcessPaymentDto, Payment>();
            CreateMap<PaymentResultDto, Payment>();
            CreateMap<Payment, PaymentResultDto>();

            //PaymentMethosDto
            CreateMap<PaymentMethod, PaymentMethodDto>();
            CreateMap<PaymentMethodDto,PaymentMethod>();
            CreateMap<PaymentMethod,CreatePaymentMethodDto>();
            CreateMap<CreatePaymentMethodDto, PaymentMethod>();
            CreateMap<PaymentMethod, UpdatePaymentMethodDto>();
            CreateMap<UpdatePaymentMethodDto, PaymentMethod>();
            // RoleDto
            CreateMap<Role, RoleCreateDto>();
            CreateMap<RoleCreateDto,Role>();
            CreateMap<Role, RoleReadDto>();
            CreateMap<RoleReadDto, Role>();

            //TaxBracket
            CreateMap<CreateTaxBracketDto, TaxBracket>();
            CreateMap<GrossSalaryDto, TaxBracket>();


        }
    }
}
