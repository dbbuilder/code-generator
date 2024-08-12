using System.Threading.Tasks;
using StudentTrackAPI.Models;

namespace StudentTrackAPI.DataAccess
{
    /// <summary>
    /// Defines the repository interface for the StudentTrackAPI namespace.
    /// </summary>
    public interface IStudentTrackAPIRepository
    {
        Task AddEmployeeNote();
Task AddTimeItemNoteRequest();
Task AdminLoginRequest();
Task AdminLoginWithKeyRequest();
Task CheckInPersonRequest();
Task CheckInPerson_InONLYRequest();
Task CheckUniqueFieldRequest();
Task Club_CheckOutPersonRequest();
Task GetEmployeeNoteByDate();
Task GetPersonForAdminRequest();
Task GetPersonForCheckInRequest();
Task GetPersonList_NotEligibleRequest();
Task LookupClubsRequest();
Task SelectEmployeeBiography();
Task SelectEmployeeID_BySSN();
Task SelectEmployeePeriodSchedule();
Task SelectEmployeeSSN_ByID();
Task SelectLocationClockInRequest();
Task Time_GetClockStatus_By_LocationIDRequest();
Task UpdateEmployeeBiography();
Task UpdateEmployeeBiography_BySSN();
Task UpdateEmployeePeriodSchedule();
Task UpdateLogEntryRequest();
Task UpdatePersonEventEligibilityByCodeRequest();
Task UpdatePersonEventEligibilityBySSNRequest();
Task UpdatePersonEventEligibilityRequest();
Task UpdatePersonRequest();

    }
}
