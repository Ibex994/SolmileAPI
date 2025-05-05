using Solmile.Models;

namespace SolmileAPI.Enum
{
    public enum AssignContactResult
    {
        Success,
        BranchNotFound,
        ContactNotFound
    }

    public enum AssignBranchResult
    {
        Success,
        ContactNotFound,
        BranchNotFound,
        ContactAlreadyAssigned,
        BranchAlreadyAssigned
    }
    public enum AssignContactResults
    {
        Success,
        BranchNotFound,
        ContactNotFound,
        BranchAlreadyAssigned,
        ContactAlreadyAssigned,
        Failure
    }

    public enum UnassignContactResult
    {
        Success,
        ContactNotFound,
        BranchNotFound,
        ContactAlreadyUnassigned,
        BranchContactMismatch,
        DatabaseError
    }

    public enum AttendanceResponse
    {
        Success,
        NotFound,
        Duplicate,
        Error,
        InvalidInput
    }

    public enum LogLevel
    {
        Info = 1,
        Warning = 2,
        Error = 3,
        Critical = 4
    }
}
