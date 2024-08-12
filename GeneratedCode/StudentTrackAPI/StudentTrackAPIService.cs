using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using StudentTrackAPI.DataAccess;
using StudentTrackAPI.Models;

namespace StudentTrackAPI.Business
{
    /// <summary>
    /// Service class for the StudentTrackAPI namespace.
    /// </summary>
    public class StudentTrackAPIService : IStudentTrackAPIService
    {
        private readonly IStudentTrackAPIService _repository;
        private readonly ILogger<StudentTrackAPIService> _logger;

        public StudentTrackAPIService(IStudentTrackAPIService repository, ILogger<StudentTrackAPIService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

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
