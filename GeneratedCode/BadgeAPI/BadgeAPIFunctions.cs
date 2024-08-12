using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BadgeAPI.API
{
    public class BadgeAPIFunctions
    {
        private readonly ILogger<BadgeAPIFunctions> _logger;
        private readonly IBadgeAPIService _BadgeAPIService;

        public BadgeAPIFunctions(ILogger<BadgeAPIFunctions> logger, IBadgeAPIService BadgeAPIService)
        {
            _logger = logger;
            _BadgeAPIService = BadgeAPIService;
        }

        public async object AttachWalletToAccountRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.AttachWalletToAccountRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in AttachWalletToAccountRequest");
        throw;
    }
}
public async object BadgeAddEventRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeAddEventRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeAddEventRequest");
        throw;
    }
}
public async object BadgeAddWalletAccountRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeAddWalletAccountRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeAddWalletAccountRequest");
        throw;
    }
}
public async object BadgeBulkUploadRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeBulkUploadRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeBulkUploadRequest");
        throw;
    }
}
public async object BadgeClockInRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeClockInRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeClockInRequest");
        throw;
    }
}
public async object BadgeClockOutRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeClockOutRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeClockOutRequest");
        throw;
    }
}
public async object BadgeForgotPasswordRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeForgotPasswordRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeForgotPasswordRequest");
        throw;
    }
}
public async object BadgeGenerateFileNameRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeGenerateFileNameRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeGenerateFileNameRequest");
        throw;
    }
}
public async object BadgeGetImageBlobRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeGetImageBlobRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeGetImageBlobRequest");
        throw;
    }
}
public async object BadgeLogin2Request()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeLogin2Request();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeLogin2Request");
        throw;
    }
}
public async object BadgeLoginRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeLoginRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeLoginRequest");
        throw;
    }
}
public async object BadgeLogin_AdminRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeLogin_AdminRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeLogin_AdminRequest");
        throw;
    }
}
public async object BadgeLogin_ValidateRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeLogin_ValidateRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeLogin_ValidateRequest");
        throw;
    }
}
public async object BadgeLookupRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeLookupRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeLookupRequest");
        throw;
    }
}
public async object BadgeSetupNewRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeSetupNewRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeSetupNewRequest");
        throw;
    }
}
public async object BadgeSetupRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeSetupRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeSetupRequest");
        throw;
    }
}
public async object BadgeStoreImageBlobRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeStoreImageBlobRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeStoreImageBlobRequest");
        throw;
    }
}
public async object BadgeStoreImageRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeStoreImageRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeStoreImageRequest");
        throw;
    }
}
public async object BadgeTimeclockHistoryRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.BadgeTimeclockHistoryRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeTimeclockHistoryRequest");
        throw;
    }
}
public async object Badge_BadgeDesignID_GetDefaultValues()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.Badge_BadgeDesignID_GetDefaultValues();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in Badge_BadgeDesignID_GetDefaultValues");
        throw;
    }
}
public async object Badge_DismissBadgeAlertRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.Badge_DismissBadgeAlertRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in Badge_DismissBadgeAlertRequest");
        throw;
    }
}
public async object Badge_SendBadgeInvitation_BadgeIDRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.Badge_SendBadgeInvitation_BadgeIDRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in Badge_SendBadgeInvitation_BadgeIDRequest");
        throw;
    }
}
public async object Badge_SendBadgeInvitation_BadgeID_ImportRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.Badge_SendBadgeInvitation_BadgeID_ImportRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in Badge_SendBadgeInvitation_BadgeID_ImportRequest");
        throw;
    }
}
public async object Badge_SendMessage_BadgeIDRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.Badge_SendMessage_BadgeIDRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in Badge_SendMessage_BadgeIDRequest");
        throw;
    }
}
public async object Badge_UpdateBadgeInformation_UserEditRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.Badge_UpdateBadgeInformation_UserEditRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in Badge_UpdateBadgeInformation_UserEditRequest");
        throw;
    }
}
public async object CheckUniqueFieldRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.CheckUniqueFieldRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in CheckUniqueFieldRequest");
        throw;
    }
}
public async object DeactivateDocumentRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.DeactivateDocumentRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in DeactivateDocumentRequest");
        throw;
    }
}
public async object DocumentListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.DocumentListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in DocumentListRequest");
        throw;
    }
}
public async object DocumentList_ByLocationRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.DocumentList_ByLocationRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in DocumentList_ByLocationRequest");
        throw;
    }
}
public async object DocumentList_ExternalSignatureIncompleteRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.DocumentList_ExternalSignatureIncompleteRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in DocumentList_ExternalSignatureIncompleteRequest");
        throw;
    }
}
public async object ForgotPassword_AppURLRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.ForgotPassword_AppURLRequest();
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
        return await _BadgeAPIService.GenerateDocumentFileNameRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in GenerateDocumentFileNameRequest");
        throw;
    }
}
public async object GetDocumentRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.GetDocumentRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in GetDocumentRequest");
        throw;
    }
}
public async object GetDocument_ByExternalSignatureIDRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.GetDocument_ByExternalSignatureIDRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in GetDocument_ByExternalSignatureIDRequest");
        throw;
    }
}
public async object PersonList3Request()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.PersonList3Request();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in PersonList3Request");
        throw;
    }
}
public async object PersonList4Request()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.PersonList4Request();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in PersonList4Request");
        throw;
    }
}
public async object PersonListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.PersonListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in PersonListRequest");
        throw;
    }
}
public async object RefreshValidationBatchRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.RefreshValidationBatchRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in RefreshValidationBatchRequest");
        throw;
    }
}
public async object SelectAccountDueByPersonRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectAccountDueByPersonRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectAccountDueByPersonRequest");
        throw;
    }
}
public async object SelectAccountTransactionList_ByPersonRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectAccountTransactionList_ByPersonRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectAccountTransactionList_ByPersonRequest");
        throw;
    }
}
public async object SelectBadgeAlertTemplateListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectBadgeAlertTemplateListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectBadgeAlertTemplateListRequest");
        throw;
    }
}
public async object SelectBadgeAlertsRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectBadgeAlertsRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectBadgeAlertsRequest");
        throw;
    }
}
public async object SelectBadgeContactsRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectBadgeContactsRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectBadgeContactsRequest");
        throw;
    }
}
public async object SelectBadgeDesignListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectBadgeDesignListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectBadgeDesignListRequest");
        throw;
    }
}
public async object SelectBadgeDesignRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectBadgeDesignRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectBadgeDesignRequest");
        throw;
    }
}
public async object SelectBadgeDesign_DefaultRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectBadgeDesign_DefaultRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectBadgeDesign_DefaultRequest");
        throw;
    }
}
public async object SelectBadgeInformationListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectBadgeInformationListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectBadgeInformationListRequest");
        throw;
    }
}
public async object SelectBadgeListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectBadgeListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectBadgeListRequest");
        throw;
    }
}
public async object SelectBadgeList_UsePersonIsActiveRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectBadgeList_UsePersonIsActiveRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectBadgeList_UsePersonIsActiveRequest");
        throw;
    }
}
public async object SelectBadgeMenuRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectBadgeMenuRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectBadgeMenuRequest");
        throw;
    }
}
public async object SelectClassListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectClassListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectClassListRequest");
        throw;
    }
}
public async object SelectDepartmentListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectDepartmentListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectDepartmentListRequest");
        throw;
    }
}
public async object SelectEventListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectEventListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEventListRequest");
        throw;
    }
}
public async object SelectGuestByEmailRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectGuestByEmailRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectGuestByEmailRequest");
        throw;
    }
}
public async object SelectImageBatchRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectImageBatchRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectImageBatchRequest");
        throw;
    }
}
public async object SelectInstitutionInfoRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectInstitutionInfoRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectInstitutionInfoRequest");
        throw;
    }
}
public async object SelectLocationInfoRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectLocationInfoRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectLocationInfoRequest");
        throw;
    }
}
public async object SelectLocationListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectLocationListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectLocationListRequest");
        throw;
    }
}
public async object SelectMessageTemplateListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectMessageTemplateListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectMessageTemplateListRequest");
        throw;
    }
}
public async object SelectMessageTemplateTokenListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectMessageTemplateTokenListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectMessageTemplateTokenListRequest");
        throw;
    }
}
public async object SelectMessageTemplateTypeListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectMessageTemplateTypeListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectMessageTemplateTypeListRequest");
        throw;
    }
}
public async object SelectPersonInfoRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectPersonInfoRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPersonInfoRequest");
        throw;
    }
}
public async object SelectPersonRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectPersonRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPersonRequest");
        throw;
    }
}
public async object SelectPersonRoleListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectPersonRoleListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPersonRoleListRequest");
        throw;
    }
}
public async object SelectPersonStatusListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectPersonStatusListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPersonStatusListRequest");
        throw;
    }
}
public async object SelectPhotoRequirementsRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectPhotoRequirementsRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPhotoRequirementsRequest");
        throw;
    }
}
public async object SelectRejectReasonListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectRejectReasonListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectRejectReasonListRequest");
        throw;
    }
}
public async object SelectRoleListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectRoleListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectRoleListRequest");
        throw;
    }
}
public async object SelectValidationBatchRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SelectValidationBatchRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectValidationBatchRequest");
        throw;
    }
}
public async object SendBadgeAlertRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SendBadgeAlertRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SendBadgeAlertRequest");
        throw;
    }
}
public async object StoreDocumentRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.StoreDocumentRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in StoreDocumentRequest");
        throw;
    }
}
public async object StoreDocumentSignatureRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.StoreDocumentSignatureRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in StoreDocumentSignatureRequest");
        throw;
    }
}
public async object SyncAccountRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.SyncAccountRequest();
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
        return await _BadgeAPIService.SyncEmployeeGuestRequest();
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
        return await _BadgeAPIService.UpdateAccountRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateAccountRequest");
        throw;
    }
}
public async object UpdateBadgeAlertTemplateRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdateBadgeAlertTemplateRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateBadgeAlertTemplateRequest");
        throw;
    }
}
public async object UpdateBadgeDesignRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdateBadgeDesignRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateBadgeDesignRequest");
        throw;
    }
}
public async object UpdateBadgeInformationRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdateBadgeInformationRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateBadgeInformationRequest");
        throw;
    }
}
public async object UpdateDepartment_BadgeDesignID_Default()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdateDepartment_BadgeDesignID_Default();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateDepartment_BadgeDesignID_Default");
        throw;
    }
}
public async object UpdateDocument_ExternalSigningCompleteRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdateDocument_ExternalSigningCompleteRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateDocument_ExternalSigningCompleteRequest");
        throw;
    }
}
public async object UpdateGuestActivationByEmployeeIDRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdateGuestActivationByEmployeeIDRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateGuestActivationByEmployeeIDRequest");
        throw;
    }
}
public async object UpdateGuestEmployeeIDRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdateGuestEmployeeIDRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateGuestEmployeeIDRequest");
        throw;
    }
}
public async object UpdateImageScoreRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdateImageScoreRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateImageScoreRequest");
        throw;
    }
}
public async object UpdateInstitution_BadgeDesignID_Default()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdateInstitution_BadgeDesignID_Default();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateInstitution_BadgeDesignID_Default");
        throw;
    }
}
public async object UpdateLocation_BadgeDesignID_Default()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdateLocation_BadgeDesignID_Default();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateLocation_BadgeDesignID_Default");
        throw;
    }
}
public async object UpdateLogEntryRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdateLogEntryRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateLogEntryRequest");
        throw;
    }
}
public async object UpdateMessageTemplateRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdateMessageTemplateRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateMessageTemplateRequest");
        throw;
    }
}
public async object UpdatePersonDetailsRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdatePersonDetailsRequest();
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
        return await _BadgeAPIService.UpdatePersonRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdatePersonRequest");
        throw;
    }
}
public async object UpdatePhotoRequirementsRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdatePhotoRequirementsRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdatePhotoRequirementsRequest");
        throw;
    }
}
public async object UpdateWalletRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.UpdateWalletRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateWalletRequest");
        throw;
    }
}
public async object ValidateImageRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.ValidateImageRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in ValidateImageRequest");
        throw;
    }
}
public async object ValidationHelper()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.ValidationHelper();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in ValidationHelper");
        throw;
    }
}
public async object ViewBadgeAlertLogRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.ViewBadgeAlertLogRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in ViewBadgeAlertLogRequest");
        throw;
    }
}
public async object WalletChangePasswordRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _BadgeAPIService.WalletChangePasswordRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in WalletChangePasswordRequest");
        throw;
    }
}

    }
}
