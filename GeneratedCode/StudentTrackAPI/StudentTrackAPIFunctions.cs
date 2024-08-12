using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace StudentTrackAPI.API
{
    public class StudentTrackAPIFunctions
    {
        private readonly ILogger<StudentTrackAPIFunctions> _logger;
        private readonly IStudentTrackAPIService _StudentTrackAPIService;

        public StudentTrackAPIFunctions(ILogger<StudentTrackAPIFunctions> logger, IStudentTrackAPIService StudentTrackAPIService)
        {
            _logger = logger;
            _StudentTrackAPIService = StudentTrackAPIService;
        }

        public async object AddEmployeeNote()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.AddEmployeeNote();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in AddEmployeeNote");
        throw;
    }
}
public async object AddTimeItemNoteRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.AddTimeItemNoteRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in AddTimeItemNoteRequest");
        throw;
    }
}
public async object AdminLoginRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.AdminLoginRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in AdminLoginRequest");
        throw;
    }
}
public async object AdminLoginWithKeyRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.AdminLoginWithKeyRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in AdminLoginWithKeyRequest");
        throw;
    }
}
public async object CheckInPersonRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.CheckInPersonRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in CheckInPersonRequest");
        throw;
    }
}
public async object CheckInPerson_InONLYRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.CheckInPerson_InONLYRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in CheckInPerson_InONLYRequest");
        throw;
    }
}
public async object CheckUniqueFieldRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.CheckUniqueFieldRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in CheckUniqueFieldRequest");
        throw;
    }
}
public async object Club_CheckOutPersonRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.Club_CheckOutPersonRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in Club_CheckOutPersonRequest");
        throw;
    }
}
public async object GetEmployeeNoteByDate()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.GetEmployeeNoteByDate();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in GetEmployeeNoteByDate");
        throw;
    }
}
public async object GetPersonForAdminRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.GetPersonForAdminRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in GetPersonForAdminRequest");
        throw;
    }
}
public async object GetPersonForCheckInRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.GetPersonForCheckInRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in GetPersonForCheckInRequest");
        throw;
    }
}
public async object GetPersonList_NotEligibleRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.GetPersonList_NotEligibleRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in GetPersonList_NotEligibleRequest");
        throw;
    }
}
public async object LookupClubsRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.LookupClubsRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in LookupClubsRequest");
        throw;
    }
}
public async object SelectEmployeeBiography()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.SelectEmployeeBiography();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployeeBiography");
        throw;
    }
}
public async object SelectEmployeeID_BySSN()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.SelectEmployeeID_BySSN();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployeeID_BySSN");
        throw;
    }
}
public async object SelectEmployeePeriodSchedule()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.SelectEmployeePeriodSchedule();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployeePeriodSchedule");
        throw;
    }
}
public async object SelectEmployeeSSN_ByID()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.SelectEmployeeSSN_ByID();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployeeSSN_ByID");
        throw;
    }
}
public async object SelectLocationClockInRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.SelectLocationClockInRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectLocationClockInRequest");
        throw;
    }
}
public async object Time_GetClockStatus_By_LocationIDRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.Time_GetClockStatus_By_LocationIDRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in Time_GetClockStatus_By_LocationIDRequest");
        throw;
    }
}
public async object UpdateEmployeeBiography()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.UpdateEmployeeBiography();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateEmployeeBiography");
        throw;
    }
}
public async object UpdateEmployeeBiography_BySSN()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.UpdateEmployeeBiography_BySSN();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateEmployeeBiography_BySSN");
        throw;
    }
}
public async object UpdateEmployeePeriodSchedule()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.UpdateEmployeePeriodSchedule();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateEmployeePeriodSchedule");
        throw;
    }
}
public async object UpdateLogEntryRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.UpdateLogEntryRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateLogEntryRequest");
        throw;
    }
}
public async object UpdatePersonEventEligibilityByCodeRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.UpdatePersonEventEligibilityByCodeRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdatePersonEventEligibilityByCodeRequest");
        throw;
    }
}
public async object UpdatePersonEventEligibilityBySSNRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.UpdatePersonEventEligibilityBySSNRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdatePersonEventEligibilityBySSNRequest");
        throw;
    }
}
public async object UpdatePersonEventEligibilityRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.UpdatePersonEventEligibilityRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdatePersonEventEligibilityRequest");
        throw;
    }
}
public async object UpdatePersonRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _StudentTrackAPIService.UpdatePersonRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdatePersonRequest");
        throw;
    }
}

    }
}
