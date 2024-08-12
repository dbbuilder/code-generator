DECLARE @StoredProcedureName NVARCHAR(128);

CREATE TABLE #Dependencies (
    ObjectName NVARCHAR(128),
    ObjectType NVARCHAR(128)
);
INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'AddAdminLink'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_Login2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'DeleteAdminLink'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SendForgotPasswordEmail_ByAppURL'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectAdminLinkList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectPerson_AdminAccess'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectPerson_byEmail'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Wallet_ChangePassword'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SyncAccount'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_ViewTimeclockHistory'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_AddWalletAndAccount'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_BulkUploadFile'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_CheckOutPerson'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_CheckInPerson_Event'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SendForgotPasswordEmail'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_GenerateImageFileName'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectImageBlob'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_Login'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_Login_Admin'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_Login_Validate'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_Lookup'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SetupNewBadge'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_Setup'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_StoreImageBlob'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_StoreImage'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectDocumentList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_BadgeDesignID_GetDefaultValues'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_DismissBadgeAlert'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SendBadgeInvitation_BadgeID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SendBadgeInvitation_AHEC_IDCard'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SendMessage_BadgeID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_UpdateBadgeInformation_UserEdit'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectAccountDue_ByPerson'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectDocument'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectDocumentList_ByLocation'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Document_GenerateFileName'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateDocument_ExternalSigningComplete'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Document_StoreDocument'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectDocument_ByExternalSignatureID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectDocumentList_ExternalSigningIncomplete'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectPersonList4'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdatePerson_Details'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectPersonList3'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_RefreshBatch'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateWallet'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectBadgeAlertTemplateList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectBadgeAlert'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectBadgeInformationList_ByBadge'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectBadgeDesignList2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectBadgeDesign'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectBadgeDesign_Default'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectBadgeInformationList2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectBadgeList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectBadgeList_UsePersonIsActive'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectBadgeMenuList_ByBadge'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectClassList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectAccountTransactionList_ByPerson'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_CheckInPerson3'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateGuestActivation_ByEmployeeID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_UpdateImage_ValidationScore'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectInstitutionInfo'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectLocationInfo'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectLocationList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectMessageTemplate'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectMessageTemplateTokenList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectMessageTemplateTypeList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectPersonInfo'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectPerson'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectEventList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectDepartmentList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectPhotoRequirements'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectBadgeRejectReasonList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectDefaultRoleList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectImageValidationBatch2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SendBadgeAlertFromTemplate'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Document_StoreDocumentSignature'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Document_DeactivateDocument'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateLogEntry'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Set_ARStatus_ByPerson'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateWallet_Account'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_UpdateBadgeAlertTemplate'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_UpdateBadgeDesign'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_UpdateBadgeInformation'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_UpdateLocation_BadgeDesignID_Default'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectPersonList2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateGuest_EmployeeID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SyncEmployee_Guest_ByEmployeeID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectPersonRoleList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_UpdateInstitution_BadgeDesignID_Default'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectGuest_ByEmail'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateMessageTemplate'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'CheckUniqueField'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectPersonStatusList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_UpdatePhotoRequirements'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateAccount'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_ValidateImage'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectImageScoringBatch'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_ViewBadgeAlertLog'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdatePerson'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateEmployee_CriticalFailureCount'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectProcedureInstanceHistoryList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'RemoveProcedureInstance'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Time_CheckOutPerson'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Time_GetClockStatus_By_ProcedureSequenceID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Time_CheckOutPerson_Event'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'LinkProcedureInstance_Instructor2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'TPR_SelectNewData_Daily'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'ApproveEmployeeTimeCardItem'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateEmployeeTimeCardItemNote'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'EditEmployeeTimeCardItem_DateTimes'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Web_ViewEmployeeTimeCardItemList_TruckTrack_TimeAdmin'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'RemoveEmployeeTimeCardItem'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'EditEmployeeTimeCardItem3'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Time_SelectAccumulatedTime'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Time_CheckInPerson_Event'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Time_SelectEventList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectMaxEvalBatch_ProcedureInstance'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Time_CheckInPerson3'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Grade_GetEventID_ByProcedureSequenceID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Time_GetClockStatus'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEvalComment'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SaveCompleteProcedureInstance'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'ViewProcedureSequence'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UnsubmitProcedureInstance'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateProcedureInstance_Signature_Student'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_SelectPersonImage'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectProductListForAdmin3'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectPerson_TPR'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectStudentGroupList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Time_SelectRoster'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectCertificateCourse'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'AddProcedureInstanceHistory'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeForTimeClock_ByCode3'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeJobEvalTimeClock'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Web_ViewEmployeeTimeCardItemList_TruckTrack2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeTimeCardItems_Open'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'TruckTrack_GetTimeAndGradeData_ByStudent'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeJobList_ByInstructor'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectProcedureInstance_ByStudent'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectGradingQueue_Eval'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectInstructorList2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectInstructor_Location'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectLocationList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectLocationStationList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectProcedureInstanceList_byEvalBatchNumber'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'TruckTrack_GetStudent'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'TruckTrack_GetTestData'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeTimeCardItem'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'TPR_SelectReport'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdatePerson_TPR'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectProcedureInstanceList_byProcedureSequence'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectProcedureInstanceList_byProcedureSequence_Completed'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'ViewProcedureInstance'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateProcedureInstance_Signature'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectProcedureSequenceProficiencyRules'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectProcedureSequenceList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectProcedureSequenceList_BatchEval'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'AddEmployeeFile'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectProcedureType_EmployeeStatusList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectProcedureTypeList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectProcedureTypeList_ByEmployeeJob'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectSalonTimeOffset_API'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectSponsorList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeStatusList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectStudentList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectProcedureSequenceFailureRules'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectPersonTestType'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'TruckTrack_GetNewStudentData'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectTimeItems_Eval'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'TruckTrack_GetOnboardTrackerData'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'TruckTrack_GetCertificate'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'TPR_MarkAsUploadFailed'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'TPR_MarkAsUploaded'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Grade_SelectAccumulatedComments_ByProcedure2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployee_CriticalFailureCount'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectProcedureInstance_Signature'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'CreateProcedureInstance'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateProcedureInstance_CommentDate'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateProcedureInstance_ByID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateProcedureInstanceStepComponent'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateProcedureInstance_Miles'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateProcedureInstance_DateTime'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'ViewProcedureInstance_Eval'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateProcedureInstanceStep'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'ViewProcedureInstanceStepIntructor_Eval'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Grade_GetCourseAndEventIDs_ByProcedureSequenceID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'AddEmployeeNote2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'AddPersonTest'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'AddAdminTransaction2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'LookupPerson'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectAccount_BadgeNumber'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectAccountList_ByFKID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectAccountTransaction'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectDocumentType_Product'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeSecurityAppItemList_All'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeStatusNewPersonRequiredFieldsList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployee_EmployeeStatus'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectMealPlan_ByPerson'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Wallet_SelectLocationList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectMealPlanList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeFile '
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeNote2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectPerson2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectPersonTest'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Ecommerce_SelectProduct'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Ecommerce_SelectProductTypeList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectSecurityAppItemList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectStateList2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectStudentGroupNewPersonRequiredFieldsList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Select_TuitionPaymentType'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectWalletList_ByFKID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Ecommerce_SetupProductSaleTransaction'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SyncAccount_BadgeNumber'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateAccountTransaction_Note'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateAccountTransaction'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_DeactivateBadge'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Badge_UpdateBadge_Location'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateEmployeeSecurityAppItem'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateEmployee_EmployeeJob'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateEmployee_EmployeeStatus'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateEmployeeDefaultJob'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateMealPlan_ByPerson'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateGuest_ByEmployeeID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdatePersonTest'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdatePerson_Activation'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdatePerson_OptIn'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateStudent_IsActive'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'WalletLogin3'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'WalletLogin5'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'AddEmployeeNote'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Club_AdminLogin2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Club_AdminLogin_WithKey'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Club_CheckInPerson2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Club_CheckInPerson_InONLY'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Club_CheckOutPerson'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeNote_ByDate'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Club_SelectPersonByCode2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeList_NotEventEligible'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Club_SelectClubList2'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeBiography'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeID_BySSN'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeePeriodScheduleList'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectEmployeeSSN_ByID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'SelectLocationClockIn'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'Time_GetClockStatus_By_LocationID'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateEmployeeBiography'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateEmployeeBiography_BySSN'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateEmployeePeriodSchedule'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateEmployee_IsEventEligible_ByCode'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateEmployee_IsEventEligible_BySSN'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdateEmployee_IsEventEligible'
;INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = 'UpdatePerson_StudentTrack'
;DECLARE @i INT
SET @i = 1

WHILE @i < 20
BEGIN
    INSERT INTO #Dependencies (ObjectName, ObjectType)
    SELECT 
        OBJECT_NAME(referenced_id) AS ObjectName,
        referenced_class_desc AS ObjectType
    FROM 
        sys.sql_expression_dependencies 
    WHERE 
        referencing_id IN (SELECT object_id(ObjectName) FROM #Dependencies)
        AND referenced_entity_name NOT IN (SELECT ObjectName FROM #Dependencies)

    SET @i = @i + 1
END

SELECT DISTINCT so.name, so.xtype 
FROM #Dependencies AS d
INNER JOIN sysobjects AS so ON so.name = d.ObjectName
WHERE d.ObjectName IS NOT NULL
ORDER BY so.xtype, so.name

DROP TABLE #Dependencies
