using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using PersonAPI.DataAccess;
using PersonAPI.Models;

namespace PersonAPI.Business
{
    /// <summary>
    /// Service class for the PersonAPI namespace.
    /// </summary>
    public class PersonAPIService : IPersonAPIService
    {
        private readonly IPersonAPIService _repository;
        private readonly ILogger<PersonAPIService> _logger;

        public PersonAPIService(IPersonAPIService repository, ILogger<PersonAPIService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        Task AddEmployeeFileRequest();
Task AddPersonNoteRequest();
Task AddPersonTestRequest();
Task AddTransactionRequest();
Task AttachWalletToAccountRequest();
Task BadgeGenerateFileNameRequest();
Task BadgeSetupNewRequest();
Task BadgeStoreImageRequest();
Task CheckUniqueFieldRequest();
Task DocumentListRequest();
Task ForgotPassword_AppURLRequest();
Task GenerateDocumentFileNameRequest();
Task LookupPersonRequest();
Task SelectAccountBadgeNumberRequest();
Task SelectAccountListRequest();
Task SelectAccountTransactionList_ByPersonRequest();
Task SelectAccountTransactionRequest();
Task SelectDocumentTypeProductRequest();
Task SelectEmployeeSecurityAppItemListRequest();
Task SelectEmployeeStatusListRequest();
Task SelectEmployeeStatusNewPersonRequiredFieldsListRequest();
Task SelectEmployee_EmployeeStatusRequest();
Task SelectEmployee_MealPlanRequest();
Task SelectLocationListRequest();
Task SelectMealPlanListRequest();
Task SelectPersonFileRequest();
Task SelectPersonInfoRequest();
Task SelectPersonNoteListRequest();
Task SelectPersonRequest();
Task SelectPersonTestListRequest();
Task SelectPersonTestTypeListRequest();
Task SelectPhotoRequirementsRequest();
Task SelectProductListRequest();
Task SelectProductTypeListRequest();
Task SelectRoleListRequest();
Task SelectSecurityAppItemListRequest();
Task SelectStateListRequest();
Task SelectStudentGroupListRequest();
Task SelectStudentGroupNewPersonRequiredFieldsListRequest();
Task SelectTuitionPaymentTypeListRequest();
Task SelectWalletListRequest();
Task SetupProductSaleRequest();
Task StoreDocumentRequest();
Task SyncAccountBadgeNumberRequest();
Task SyncAccountRequest();
Task SyncEmployeeGuestRequest();
Task UpdateAccountRequest();
Task UpdateAccountTransactionNoteRequest();
Task UpdateAccountTransactionRequest();
Task UpdateBadgeActivationRequest();
Task UpdateBadgeLocationRequest();
Task UpdateEmployeeSecurityAppItemRequest();
Task UpdateEmployee_AddJob_NonDefaultRequest();
Task UpdateEmployee_EmployeeStatusRequest();
Task UpdateEmployee_JobRequest();
Task UpdateEmployee_MealPlanRequest();
Task UpdateGuestByEmployeeIDRequest();
Task UpdateLogEntryRequest();
Task UpdatePersonDetailsRequest();
Task UpdatePersonRequest();
Task UpdatePersonTestRequest();
Task UpdatePerson_ActivationRequest();
Task UpdatePerson_OptInRequest();
Task UpdateStudent_IsActiveRequest();
Task UpdateWalletRequest();
Task WalletChangePasswordRequest();
Task WalletLoginUserRequest();
Task WalletLoginUser_WithInstitutionGlobalKeyRequest();

    }
}
