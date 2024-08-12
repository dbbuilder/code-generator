using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using BadgeAPI.DataAccess;
using BadgeAPI.Models;

namespace BadgeAPI.Business
{
    /// <summary>
    /// Service class for the BadgeAPI namespace.
    /// </summary>
    public class BadgeAPIService : IBadgeAPIService
    {
        private readonly IBadgeAPIService _repository;
        private readonly ILogger<BadgeAPIService> _logger;

        public BadgeAPIService(IBadgeAPIService repository, ILogger<BadgeAPIService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        Task AttachWalletToAccountRequest();
Task BadgeAddEventRequest();
Task BadgeAddWalletAccountRequest();
Task BadgeBulkUploadRequest();
Task BadgeClockInRequest();
Task BadgeClockOutRequest();
Task BadgeForgotPasswordRequest();
Task BadgeGenerateFileNameRequest();
Task BadgeGetImageBlobRequest();
Task BadgeLogin2Request();
Task BadgeLoginRequest();
Task BadgeLogin_AdminRequest();
Task BadgeLogin_ValidateRequest();
Task BadgeLookupRequest();
Task BadgeSetupNewRequest();
Task BadgeSetupRequest();
Task BadgeStoreImageBlobRequest();
Task BadgeStoreImageRequest();
Task BadgeTimeclockHistoryRequest();
Task Badge_BadgeDesignID_GetDefaultValues();
Task Badge_DismissBadgeAlertRequest();
Task Badge_SendBadgeInvitation_BadgeIDRequest();
Task Badge_SendBadgeInvitation_BadgeID_ImportRequest();
Task Badge_SendMessage_BadgeIDRequest();
Task Badge_UpdateBadgeInformation_UserEditRequest();
Task CheckUniqueFieldRequest();
Task DeactivateDocumentRequest();
Task DocumentListRequest();
Task DocumentList_ByLocationRequest();
Task DocumentList_ExternalSignatureIncompleteRequest();
Task ForgotPassword_AppURLRequest();
Task GenerateDocumentFileNameRequest();
Task GetDocumentRequest();
Task GetDocument_ByExternalSignatureIDRequest();
Task PersonList3Request();
Task PersonList4Request();
Task PersonListRequest();
Task RefreshValidationBatchRequest();
Task SelectAccountDueByPersonRequest();
Task SelectAccountTransactionList_ByPersonRequest();
Task SelectBadgeAlertTemplateListRequest();
Task SelectBadgeAlertsRequest();
Task SelectBadgeContactsRequest();
Task SelectBadgeDesignListRequest();
Task SelectBadgeDesignRequest();
Task SelectBadgeDesign_DefaultRequest();
Task SelectBadgeInformationListRequest();
Task SelectBadgeListRequest();
Task SelectBadgeList_UsePersonIsActiveRequest();
Task SelectBadgeMenuRequest();
Task SelectClassListRequest();
Task SelectDepartmentListRequest();
Task SelectEventListRequest();
Task SelectGuestByEmailRequest();
Task SelectImageBatchRequest();
Task SelectInstitutionInfoRequest();
Task SelectLocationInfoRequest();
Task SelectLocationListRequest();
Task SelectMessageTemplateListRequest();
Task SelectMessageTemplateTokenListRequest();
Task SelectMessageTemplateTypeListRequest();
Task SelectPersonInfoRequest();
Task SelectPersonRequest();
Task SelectPersonRoleListRequest();
Task SelectPersonStatusListRequest();
Task SelectPhotoRequirementsRequest();
Task SelectRejectReasonListRequest();
Task SelectRoleListRequest();
Task SelectValidationBatchRequest();
Task SendBadgeAlertRequest();
Task StoreDocumentRequest();
Task StoreDocumentSignatureRequest();
Task SyncAccountRequest();
Task SyncEmployeeGuestRequest();
Task UpdateAccountRequest();
Task UpdateBadgeAlertTemplateRequest();
Task UpdateBadgeDesignRequest();
Task UpdateBadgeInformationRequest();
Task UpdateDepartment_BadgeDesignID_Default();
Task UpdateDocument_ExternalSigningCompleteRequest();
Task UpdateGuestActivationByEmployeeIDRequest();
Task UpdateGuestEmployeeIDRequest();
Task UpdateImageScoreRequest();
Task UpdateInstitution_BadgeDesignID_Default();
Task UpdateLocation_BadgeDesignID_Default();
Task UpdateLogEntryRequest();
Task UpdateMessageTemplateRequest();
Task UpdatePersonDetailsRequest();
Task UpdatePersonRequest();
Task UpdatePhotoRequirementsRequest();
Task UpdateWalletRequest();
Task ValidateImageRequest();
Task ValidationHelper();
Task ViewBadgeAlertLogRequest();
Task WalletChangePasswordRequest();

    }
}
