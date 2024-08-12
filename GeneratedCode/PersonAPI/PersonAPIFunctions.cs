using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace PersonAPI.API
{
    public class PersonAPIFunctions
    {
        private readonly ILogger<PersonAPIFunctions> _logger;
        private readonly IPersonAPIService _PersonAPIService;

        public PersonAPIFunctions(ILogger<PersonAPIFunctions> logger, IPersonAPIService PersonAPIService)
        {
            _logger = logger;
            _PersonAPIService = PersonAPIService;
        }

        public async object AddEmployeeFileRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.AddEmployeeFileRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in AddEmployeeFileRequest");
        throw;
    }
}
public async object AddPersonNoteRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.AddPersonNoteRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in AddPersonNoteRequest");
        throw;
    }
}
public async object AddPersonTestRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.AddPersonTestRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in AddPersonTestRequest");
        throw;
    }
}
public async object AddTransactionRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.AddTransactionRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in AddTransactionRequest");
        throw;
    }
}
public async object AttachWalletToAccountRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.AttachWalletToAccountRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in AttachWalletToAccountRequest");
        throw;
    }
}
public async object BadgeGenerateFileNameRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.BadgeGenerateFileNameRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeGenerateFileNameRequest");
        throw;
    }
}
public async object BadgeSetupNewRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.BadgeSetupNewRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeSetupNewRequest");
        throw;
    }
}
public async object BadgeStoreImageRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.BadgeStoreImageRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeStoreImageRequest");
        throw;
    }
}
public async object CheckUniqueFieldRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.CheckUniqueFieldRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in CheckUniqueFieldRequest");
        throw;
    }
}
public async object DocumentListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.DocumentListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in DocumentListRequest");
        throw;
    }
}
public async object ForgotPassword_AppURLRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.ForgotPassword_AppURLRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in ForgotPassword_AppURLRequest");
        throw;
    }
}
public async object GenerateDocumentFileNameRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.GenerateDocumentFileNameRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in GenerateDocumentFileNameRequest");
        throw;
    }
}
public async object LookupPersonRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.LookupPersonRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in LookupPersonRequest");
        throw;
    }
}
public async object SelectAccountBadgeNumberRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectAccountBadgeNumberRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectAccountBadgeNumberRequest");
        throw;
    }
}
public async object SelectAccountListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectAccountListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectAccountListRequest");
        throw;
    }
}
public async object SelectAccountTransactionList_ByPersonRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectAccountTransactionList_ByPersonRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectAccountTransactionList_ByPersonRequest");
        throw;
    }
}
public async object SelectAccountTransactionRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectAccountTransactionRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectAccountTransactionRequest");
        throw;
    }
}
public async object SelectDocumentTypeProductRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectDocumentTypeProductRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectDocumentTypeProductRequest");
        throw;
    }
}
public async object SelectEmployeeSecurityAppItemListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectEmployeeSecurityAppItemListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployeeSecurityAppItemListRequest");
        throw;
    }
}
public async object SelectEmployeeStatusListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectEmployeeStatusListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployeeStatusListRequest");
        throw;
    }
}
public async object SelectEmployeeStatusNewPersonRequiredFieldsListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectEmployeeStatusNewPersonRequiredFieldsListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployeeStatusNewPersonRequiredFieldsListRequest");
        throw;
    }
}
public async object SelectEmployee_EmployeeStatusRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectEmployee_EmployeeStatusRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployee_EmployeeStatusRequest");
        throw;
    }
}
public async object SelectEmployee_MealPlanRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectEmployee_MealPlanRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployee_MealPlanRequest");
        throw;
    }
}
public async object SelectLocationListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectLocationListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectLocationListRequest");
        throw;
    }
}
public async object SelectMealPlanListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectMealPlanListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectMealPlanListRequest");
        throw;
    }
}
public async object SelectPersonFileRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectPersonFileRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPersonFileRequest");
        throw;
    }
}
public async object SelectPersonInfoRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectPersonInfoRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPersonInfoRequest");
        throw;
    }
}
public async object SelectPersonNoteListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectPersonNoteListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPersonNoteListRequest");
        throw;
    }
}
public async object SelectPersonRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectPersonRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPersonRequest");
        throw;
    }
}
public async object SelectPersonTestListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectPersonTestListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPersonTestListRequest");
        throw;
    }
}
public async object SelectPersonTestTypeListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectPersonTestTypeListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPersonTestTypeListRequest");
        throw;
    }
}
public async object SelectPhotoRequirementsRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectPhotoRequirementsRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPhotoRequirementsRequest");
        throw;
    }
}
public async object SelectProductListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectProductListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProductListRequest");
        throw;
    }
}
public async object SelectProductTypeListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectProductTypeListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProductTypeListRequest");
        throw;
    }
}
public async object SelectRoleListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectRoleListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectRoleListRequest");
        throw;
    }
}
public async object SelectSecurityAppItemListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectSecurityAppItemListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectSecurityAppItemListRequest");
        throw;
    }
}
public async object SelectStateListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectStateListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectStateListRequest");
        throw;
    }
}
public async object SelectStudentGroupListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectStudentGroupListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectStudentGroupListRequest");
        throw;
    }
}
public async object SelectStudentGroupNewPersonRequiredFieldsListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectStudentGroupNewPersonRequiredFieldsListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectStudentGroupNewPersonRequiredFieldsListRequest");
        throw;
    }
}
public async object SelectTuitionPaymentTypeListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectTuitionPaymentTypeListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectTuitionPaymentTypeListRequest");
        throw;
    }
}
public async object SelectWalletListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SelectWalletListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectWalletListRequest");
        throw;
    }
}
public async object SetupProductSaleRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SetupProductSaleRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SetupProductSaleRequest");
        throw;
    }
}
public async object StoreDocumentRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.StoreDocumentRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in StoreDocumentRequest");
        throw;
    }
}
public async object SyncAccountBadgeNumberRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SyncAccountBadgeNumberRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SyncAccountBadgeNumberRequest");
        throw;
    }
}
public async object SyncAccountRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SyncAccountRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SyncAccountRequest");
        throw;
    }
}
public async object SyncEmployeeGuestRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.SyncEmployeeGuestRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SyncEmployeeGuestRequest");
        throw;
    }
}
public async object UpdateAccountRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdateAccountRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateAccountRequest");
        throw;
    }
}
public async object UpdateAccountTransactionNoteRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdateAccountTransactionNoteRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateAccountTransactionNoteRequest");
        throw;
    }
}
public async object UpdateAccountTransactionRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdateAccountTransactionRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateAccountTransactionRequest");
        throw;
    }
}
public async object UpdateBadgeActivationRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdateBadgeActivationRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateBadgeActivationRequest");
        throw;
    }
}
public async object UpdateBadgeLocationRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdateBadgeLocationRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateBadgeLocationRequest");
        throw;
    }
}
public async object UpdateEmployeeSecurityAppItemRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdateEmployeeSecurityAppItemRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateEmployeeSecurityAppItemRequest");
        throw;
    }
}
public async object UpdateEmployee_AddJob_NonDefaultRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdateEmployee_AddJob_NonDefaultRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateEmployee_AddJob_NonDefaultRequest");
        throw;
    }
}
public async object UpdateEmployee_EmployeeStatusRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdateEmployee_EmployeeStatusRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateEmployee_EmployeeStatusRequest");
        throw;
    }
}
public async object UpdateEmployee_JobRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdateEmployee_JobRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateEmployee_JobRequest");
        throw;
    }
}
public async object UpdateEmployee_MealPlanRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdateEmployee_MealPlanRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateEmployee_MealPlanRequest");
        throw;
    }
}
public async object UpdateGuestByEmployeeIDRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdateGuestByEmployeeIDRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateGuestByEmployeeIDRequest");
        throw;
    }
}
public async object UpdateLogEntryRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdateLogEntryRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateLogEntryRequest");
        throw;
    }
}
public async object UpdatePersonDetailsRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdatePersonDetailsRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdatePersonDetailsRequest");
        throw;
    }
}
public async object UpdatePersonRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdatePersonRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdatePersonRequest");
        throw;
    }
}
public async object UpdatePersonTestRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdatePersonTestRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdatePersonTestRequest");
        throw;
    }
}
public async object UpdatePerson_ActivationRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdatePerson_ActivationRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdatePerson_ActivationRequest");
        throw;
    }
}
public async object UpdatePerson_OptInRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdatePerson_OptInRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdatePerson_OptInRequest");
        throw;
    }
}
public async object UpdateStudent_IsActiveRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdateStudent_IsActiveRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateStudent_IsActiveRequest");
        throw;
    }
}
public async object UpdateWalletRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.UpdateWalletRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateWalletRequest");
        throw;
    }
}
public async object WalletChangePasswordRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.WalletChangePasswordRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in WalletChangePasswordRequest");
        throw;
    }
}
public async object WalletLoginUserRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.WalletLoginUserRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in WalletLoginUserRequest");
        throw;
    }
}
public async object WalletLoginUser_WithInstitutionGlobalKeyRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _PersonAPIService.WalletLoginUser_WithInstitutionGlobalKeyRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in WalletLoginUser_WithInstitutionGlobalKeyRequest");
        throw;
    }
}

    }
}
