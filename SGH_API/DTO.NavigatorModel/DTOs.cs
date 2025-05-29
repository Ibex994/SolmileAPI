using System.Text.Json.Serialization;

namespace SolmileGuesthouseAPI.DTO.NavigatorModel
{
    public class DTOs
    {
        // DTOs/BranchDto.cs
        public class BranchDto
        {
            public int BranchId { get; set; }
            public string Location { get; set; }
            public string Name { get; set; }
            public int ContactId { get; set; }
            [JsonIgnore]
            public ContactDetailsDto ContactDetails { get; set; }
        }

        public class UInsertionBranchDto
        {
            [JsonIgnore]
            public int BranchId { get; set; }
            public string Location { get; set; }
            public string Name { get; set; }
            public int ContactId { get; set; }
            //public ContactDetailsDto ContactDetails { get; set; }
        }

        // DTOs/ContactDetailsDto.cs
        public class ContactDetailsDto
        {

            public int ContactId { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string EmergencyContact { get; set; }
        }

        // DTOs/UInsertionContactDetailsDto.cs
        public class UInsertionContactDetailsDto
        {
            [JsonIgnore]
            public int ContactId { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string EmergencyContact { get; set; }
        }

        // DTOs/CustomerDto.cs
        public class CustomerDto
        {
            public int CustomerId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Gender { get; set; }
            public string? Phone { get; set; }
            public string Email { get; set; }
        }
        public class UInsertCustomerDto
        {
            [JsonIgnore]
            public int CustomerId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Gender { get; set; }
            public string? Phone { get; set; }
            public string Email { get; set; }
        }

        // DTOs/EmployeeDto.cs
        public class EmployeeDto
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Position { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public DateTime DateOfBirth { get; set; }
            public DateTime HireDate { get; set; }
            public bool Status { get; set; }
            public string Gender { get; set; }
            public int BranchId { get; set; }
        }
        public class InsertionEmployeeDto
        {
            [JsonIgnore]
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Position { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public DateTime DateOfBirth { get; set; }
            public DateTime HireDate { get; set; }
            public bool Status { get; set; }
            public string Gender { get; set; }
            public int BranchId { get; set; }
        }
        public class UpdateEmployeeDto
        {
            [JsonIgnore]
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Position { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public DateTime DateOfBirth { get; set; }
            public DateTime HireDate { get; set; }
            public bool Status { get; set; }
            public string Gender { get; set; }
            public int BranchId { get; set; }
        }

     

        // DTOs/RatingDto.cs
        public class RatingDto
        {
            public int RatingId { get; set; }
            public int EmployeeId { get; set; }
            public int ServiceRequestId { get; set; }
            public float RatingValue { get; set; }
            public DateTime RatingDate { get; set; }
            public string GivenBy { get; set; }
        }
        public class UInsertionRatingDto
        {
            [JsonIgnore]
            public int RatingId { get; set; }
            public int EmployeeId { get; set; }
            public int ServiceRequestId { get; set; }
            public float RatingValue { get; set; }
            public DateTime RatingDate { get; set; }
            public string GivenBy { get; set; }
        }

        // DTOs/ReservationDto.cs
        public class ReservationDto
        {
            public string ReservationId { get; set; }
            public int CustomerId { get; set; }
            public string RoomId { get; set; }
            public DateTime CheckInDate { get; set; }
            public DateTime CheckOutDate { get; set; }
            public float TotalPrice { get; set; }
            public string Status { get; set; }
        }
        public class InsertionReservationDto
        {
            [JsonIgnore]
            public string? ReservationId { get; set; }
            public int CustomerId { get; set; }
            [JsonIgnore]
            public string? RoomId { get; set; }
            public DateTime CheckInDate { get; set; }
            public DateTime CheckOutDate { get; set; }
            [JsonIgnore]
            public float TotalPrice { get; set; }
            [JsonIgnore]
            public string? Status { get; set; }
        }
        public class UpdateReservationDto
        {
            [JsonIgnore]
            public string? ReservationId { get; set; }
            public string Status { get; set; }
        }

        // DTOs/RoomDto.cs
        public class RoomDto
        {
            public string RoomId { get; set; }
            public int RoomNumberAssignmentId { get; set; }
            public string Status { get; set; }
            public int TypeId { get; set; }
        }
        //public class UInsertionRoomDto
        //{
        //    [JsonIgnore]
        //    public string RoomId { get; set; }
        //    public int RoomNumberAssignmentId { get; set; }
        //    public string Status { get; set; }
        //    public int TypeId { get; set; }
        //}

        // DTOs/RoomNumberAssignmentDto.cs
        public class RoomNumberAssignmentDto
        {
            public int RoomNumberAssignmentId { get; set; }
            public int BranchId { get; set; }
            public int RoomNumber { get; set; }
        }
        public class UInsertionRoomNumberAssignmentDto
        {
            [JsonIgnore]
            public int RoomNumberAssignmentId { get; set; }
            public int BranchId { get; set; }
            public int RoomNumber { get; set; }
        }

        // DTOs/RoomTypeDto.cs
        public class RoomTypeDto
        {
            public int TypeId { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Amenities { get; set; }
            public float PricePerNight { get; set; }
            public string Capacity { get; set; }
            public byte[]? ImageUrl { get; set; }
        }
        public class InsertionRoomTypeDto
        {
            public int TypeId { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Amenities { get; set; }
            public float PricePerNight { get; set; }
            public string Capacity { get; set; }
            public IFormFile? ImageUrl { get; set; }
        }
        public class UpdateRoomTypeDto
        {
            public string Name { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Amenities { get; set; }
            public float PricePerNight { get; set; }
            public string Capacity { get; set; }
            public IFormFile? ImageUrl { get; set; }
        }

        // DTOs/ServiceRequestDto.cs
        public class ServiceRequestDto
        {
            public int RequestId { get; set; }
            public string RequestedBy { get; set; }
            public string? ReservationId { get; set; }
            public int? EmployeeId { get; set; }
            public int ServiceTypeId { get; set; }
            public string Location { get; set; }
            public DateTime RequiredByDateTime { get; set; }
            public string Status { get; set; }
            public string ExtraDetail { get; set; }
            public byte[]? AttachPhotoUrl { get; set; }
        }
        public class UInsertionServiceRequestDto
        {
           // [JsonIgnore]
            // public int RequestId { get; set; }
            public string RequestedBy { get; set; }
            public string? ReservationId { get; set; }
            public int? EmployeeId { get; set; }
            public int ServiceTypeId { get; set; }
            public string Location { get; set; }
            public DateTime RequiredByDateTime { get; set; }
            public string ExtraDetail { get; set; }
            public IFormFile? AttachPhotoUrl { get; set; }
        }

        // DTOs/ServiceTypeDto.cs
        public class ServiceTypeDto
        {
            public int ServiceTypeId { get; set; }
            public string ServiceTypeName { get; set; }
        }
        public class UInsertionServiceTypeDto
        {
            [JsonIgnore]
            public int ServiceTypeId { get; set; }
            public string ServiceTypeName { get; set; }
        }

        // DTOs/TaskDto.cs
        public class TaskDto
        {
            public int TaskId { get; set; }
            public int RequestId { get; set; }
            public int EmployeeId { get; set; }
            public DateTime AssignedTime { get; set; }
            public string Status { get; set; }
        }
        public class UInsertionTaskDto
        {
            [JsonIgnore]
            public int TaskId { get; set; }
            public int RequestId { get; set; }
            public int EmployeeId { get; set; }
            public DateTime AssignedTime { get; set; }
            public string Status { get; set; }
        }

        // DTOs/UserDto.cs
        public class UserDto
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }
        public class UInsertionUserDto
        {
            [JsonIgnore]
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }



        //public class BulkEmployeeDto
        //{
        //    public List<InsertionEmployeeDto> Employees { get; set; }
        //}


    }
}
