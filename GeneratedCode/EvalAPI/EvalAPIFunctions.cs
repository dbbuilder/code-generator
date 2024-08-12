using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace EvalAPI.API
{
    public class EvalAPIFunctions
    {
        private readonly ILogger<EvalAPIFunctions> _logger;
        private readonly IEvalAPIService _EvalAPIService;

        public EvalAPIFunctions(ILogger<EvalAPIFunctions> logger, IEvalAPIService EvalAPIService)
        {
            _logger = logger;
            _EvalAPIService = EvalAPIService;
        }

        public async object AddEmployeeFileRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.AddEmployeeFileRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in AddEmployeeFileRequest");
        throw;
    }
}
public async object AddProcedureInstanceHistoryRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.AddProcedureInstanceHistoryRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in AddProcedureInstanceHistoryRequest");
        throw;
    }
}
public async object CheckInPersonEventRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.CheckInPersonEventRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in CheckInPersonEventRequest");
        throw;
    }
}
public async object CheckInPersonRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.CheckInPersonRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in CheckInPersonRequest");
        throw;
    }
}
public async object CheckOutPersonEvent()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.CheckOutPersonEvent();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in CheckOutPersonEvent");
        throw;
    }
}
public async object CheckOutPersonRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.CheckOutPersonRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in CheckOutPersonRequest");
        throw;
    }
}
public async object CreateProcedureInstanceRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.CreateProcedureInstanceRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in CreateProcedureInstanceRequest");
        throw;
    }
}
public async object EmployeeTPRItem_Daily_GetListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.EmployeeTPRItem_Daily_GetListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in EmployeeTPRItem_Daily_GetListRequest");
        throw;
    }
}
public async object EmployeeTimeCardItem_ApproveRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.EmployeeTimeCardItem_ApproveRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in EmployeeTimeCardItem_ApproveRequest");
        throw;
    }
}
public async object EmployeeTimeCardItem_UpdateDateTimeOnlyRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.EmployeeTimeCardItem_UpdateDateTimeOnlyRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in EmployeeTimeCardItem_UpdateDateTimeOnlyRequest");
        throw;
    }
}
public async object EmployeeTimeCardItem_UpdateRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.EmployeeTimeCardItem_UpdateRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in EmployeeTimeCardItem_UpdateRequest");
        throw;
    }
}
public async object EmployeeTimeItem_GetListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.EmployeeTimeItem_GetListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in EmployeeTimeItem_GetListRequest");
        throw;
    }
}
public async object EmployeeTimeItem_RemoveRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.EmployeeTimeItem_RemoveRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in EmployeeTimeItem_RemoveRequest");
        throw;
    }
}
public async object EmployeeTimeItem_UpdateNoteRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.EmployeeTimeItem_UpdateNoteRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in EmployeeTimeItem_UpdateNoteRequest");
        throw;
    }
}
public async object Employee_GetTimeCardIDRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.Employee_GetTimeCardIDRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in Employee_GetTimeCardIDRequest");
        throw;
    }
}
public async object ForgotPassword_AppURLRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.ForgotPassword_AppURLRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in ForgotPassword_AppURLRequest");
        throw;
    }
}
public async object GetClockStatusByProcedureSequenceID()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.GetClockStatusByProcedureSequenceID();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in GetClockStatusByProcedureSequenceID");
        throw;
    }
}
public async object GetClockStatusRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.GetClockStatusRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in GetClockStatusRequest");
        throw;
    }
}
public async object GetEventIDByProcedureSequenceID()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.GetEventIDByProcedureSequenceID();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in GetEventIDByProcedureSequenceID");
        throw;
    }
}
public async object GetStudentRosterForTimeRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.GetStudentRosterForTimeRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in GetStudentRosterForTimeRequest");
        throw;
    }
}
public async object Grade_GetCourseAndEventIDs_ByProcedureSequenceID()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.Grade_GetCourseAndEventIDs_ByProcedureSequenceID();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in Grade_GetCourseAndEventIDs_ByProcedureSequenceID");
        throw;
    }
}
public async object GradingQueueResponse()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.GradingQueueResponse();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in GradingQueueResponse");
        throw;
    }
}
public async object Grading_LinkEmployeeTimeCardItem_ProcedureInstanceRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.Grading_LinkEmployeeTimeCardItem_ProcedureInstanceRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in Grading_LinkEmployeeTimeCardItem_ProcedureInstanceRequest");
        throw;
    }
}
public async object LinkProcedureInstance_InstructorRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.LinkProcedureInstance_InstructorRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in LinkProcedureInstance_InstructorRequest");
        throw;
    }
}
public async object RemoveProcedureInstanceRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.RemoveProcedureInstanceRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in RemoveProcedureInstanceRequest");
        throw;
    }
}
public async object SaveCompleteProcedureInstanceRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SaveCompleteProcedureInstanceRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SaveCompleteProcedureInstanceRequest");
        throw;
    }
}
public async object SaveProcedureInstanceSignatureRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SaveProcedureInstanceSignatureRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SaveProcedureInstanceSignatureRequest");
        throw;
    }
}
public async object SaveProcedureInstanceSignatureStudentRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SaveProcedureInstanceSignatureStudentRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SaveProcedureInstanceSignatureStudentRequest");
        throw;
    }
}
public async object SelectAccountTransactionList_ByPersonRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectAccountTransactionList_ByPersonRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectAccountTransactionList_ByPersonRequest");
        throw;
    }
}
public async object SelectAccumulatedCommentsRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectAccumulatedCommentsRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectAccumulatedCommentsRequest");
        throw;
    }
}
public async object SelectAccumulatedTimeRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectAccumulatedTimeRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectAccumulatedTimeRequest");
        throw;
    }
}
public async object SelectCertificateCourseRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectCertificateCourseRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectCertificateCourseRequest");
        throw;
    }
}
public async object SelectCourseListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectCourseListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectCourseListRequest");
        throw;
    }
}
public async object SelectEmployeeCriticalFailureCountRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectEmployeeCriticalFailureCountRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployeeCriticalFailureCountRequest");
        throw;
    }
}
public async object SelectEmployeeForTimeClockByCode()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectEmployeeForTimeClockByCode();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployeeForTimeClockByCode");
        throw;
    }
}
public async object SelectEmployeeJobEvalTimeClockRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectEmployeeJobEvalTimeClockRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployeeJobEvalTimeClockRequest");
        throw;
    }
}
public async object SelectEmployeeStatusListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectEmployeeStatusListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployeeStatusListRequest");
        throw;
    }
}
public async object SelectEmployeeTimeCardItemRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectEmployeeTimeCardItemRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployeeTimeCardItemRequest");
        throw;
    }
}
public async object SelectEmployeeTimeCardItems_OpenRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectEmployeeTimeCardItems_OpenRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEmployeeTimeCardItems_OpenRequest");
        throw;
    }
}
public async object SelectEvalCommentRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectEvalCommentRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEvalCommentRequest");
        throw;
    }
}
public async object SelectEventListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectEventListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectEventListRequest");
        throw;
    }
}
public async object SelectGradeDataRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectGradeDataRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectGradeDataRequest");
        throw;
    }
}
public async object SelectGradeData_EvalRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectGradeData_EvalRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectGradeData_EvalRequest");
        throw;
    }
}
public async object SelectGradingQueueRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectGradingQueueRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectGradingQueueRequest");
        throw;
    }
}
public async object SelectInstanceByStudentRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectInstanceByStudentRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectInstanceByStudentRequest");
        throw;
    }
}
public async object SelectInstructorListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectInstructorListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectInstructorListRequest");
        throw;
    }
}
public async object SelectInstructorLocationListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectInstructorLocationListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectInstructorLocationListRequest");
        throw;
    }
}
public async object SelectLocationListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectLocationListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectLocationListRequest");
        throw;
    }
}
public async object SelectLocationStationListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectLocationStationListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectLocationStationListRequest");
        throw;
    }
}
public async object SelectMaxEvalBatch_ProcedureInstanceRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectMaxEvalBatch_ProcedureInstanceRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectMaxEvalBatch_ProcedureInstanceRequest");
        throw;
    }
}
public async object SelectNewStudentDataRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectNewStudentDataRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectNewStudentDataRequest");
        throw;
    }
}
public async object SelectOnboardTrackerDataRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectOnboardTrackerDataRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectOnboardTrackerDataRequest");
        throw;
    }
}
public async object SelectPersonImageRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectPersonImageRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPersonImageRequest");
        throw;
    }
}
public async object SelectPersonTestTypeListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectPersonTestTypeListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPersonTestTypeListRequest");
        throw;
    }
}
public async object SelectPerson_TPRRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectPerson_TPRRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPerson_TPRRequest");
        throw;
    }
}
public async object SelectProcedureInstanceHistoryListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectProcedureInstanceHistoryListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProcedureInstanceHistoryListRequest");
        throw;
    }
}
public async object SelectProcedureInstanceList_byEvalBatchNumberRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectProcedureInstanceList_byEvalBatchNumberRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProcedureInstanceList_byEvalBatchNumberRequest");
        throw;
    }
}
public async object SelectProcedureInstanceList_byProcedureSequenceRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectProcedureInstanceList_byProcedureSequenceRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProcedureInstanceList_byProcedureSequenceRequest");
        throw;
    }
}
public async object SelectProcedureInstanceList_byProcedureSequence_CompletedRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectProcedureInstanceList_byProcedureSequence_CompletedRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProcedureInstanceList_byProcedureSequence_CompletedRequest");
        throw;
    }
}
public async object SelectProcedureInstanceSignatureRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectProcedureInstanceSignatureRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProcedureInstanceSignatureRequest");
        throw;
    }
}
public async object SelectProcedureSequenceFailureRulesRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectProcedureSequenceFailureRulesRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProcedureSequenceFailureRulesRequest");
        throw;
    }
}
public async object SelectProcedureSequenceListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectProcedureSequenceListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProcedureSequenceListRequest");
        throw;
    }
}
public async object SelectProcedureSequenceList_BatchEvalRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectProcedureSequenceList_BatchEvalRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProcedureSequenceList_BatchEvalRequest");
        throw;
    }
}
public async object SelectProcedureSequenceProficiencyRulesRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectProcedureSequenceProficiencyRulesRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProcedureSequenceProficiencyRulesRequest");
        throw;
    }
}
public async object SelectProcedureTypeEmployeeStatusListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectProcedureTypeEmployeeStatusListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProcedureTypeEmployeeStatusListRequest");
        throw;
    }
}
public async object SelectProcedureTypeListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectProcedureTypeListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProcedureTypeListRequest");
        throw;
    }
}
public async object SelectProcedureTypeList_ByJobRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectProcedureTypeList_ByJobRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProcedureTypeList_ByJobRequest");
        throw;
    }
}
public async object SelectProductListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectProductListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectProductListRequest");
        throw;
    }
}
public async object SelectSponsorListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectSponsorListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectSponsorListRequest");
        throw;
    }
}
public async object SelectStudentGroupListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectStudentGroupListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectStudentGroupListRequest");
        throw;
    }
}
public async object SelectStudentListRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectStudentListRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectStudentListRequest");
        throw;
    }
}
public async object SelectTPRDataRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectTPRDataRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectTPRDataRequest");
        throw;
    }
}
public async object SelectTestDataRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectTestDataRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectTestDataRequest");
        throw;
    }
}
public async object SelectTimeAndGradeDataRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectTimeAndGradeDataRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectTimeAndGradeDataRequest");
        throw;
    }
}
public async object SelectTimeDataRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectTimeDataRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectTimeDataRequest");
        throw;
    }
}
public async object SelectTimeItems_EvalRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectTimeItems_EvalRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectTimeItems_EvalRequest");
        throw;
    }
}
public async object SelectTimeOffsetRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectTimeOffsetRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectTimeOffsetRequest");
        throw;
    }
}
public async object SelectTruckTrackCertificateRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectTruckTrackCertificateRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectTruckTrackCertificateRequest");
        throw;
    }
}
public async object SelectTruckTrackStudentRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.SelectTruckTrackStudentRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectTruckTrackStudentRequest");
        throw;
    }
}
public async object TPR_MarkAsUploadFailedRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.TPR_MarkAsUploadFailedRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in TPR_MarkAsUploadFailedRequest");
        throw;
    }
}
public async object TPR_MarkAsUploadedRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.TPR_MarkAsUploadedRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in TPR_MarkAsUploadedRequest");
        throw;
    }
}
public async object UnsubmitProcedureInstanceRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.UnsubmitProcedureInstanceRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UnsubmitProcedureInstanceRequest");
        throw;
    }
}
public async object UpdateEmployeeCriticalFailure()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.UpdateEmployeeCriticalFailure();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateEmployeeCriticalFailure");
        throw;
    }
}
public async object UpdatePerson_TPRRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.UpdatePerson_TPRRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdatePerson_TPRRequest");
        throw;
    }
}
public async object UpdateProcedureInstanceDateTimeRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.UpdateProcedureInstanceDateTimeRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateProcedureInstanceDateTimeRequest");
        throw;
    }
}
public async object UpdateProcedureInstanceRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.UpdateProcedureInstanceRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateProcedureInstanceRequest");
        throw;
    }
}
public async object UpdateProcedureInstanceStepComponentRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.UpdateProcedureInstanceStepComponentRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateProcedureInstanceStepComponentRequest");
        throw;
    }
}
public async object UpdateProcedureInstanceStepRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.UpdateProcedureInstanceStepRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateProcedureInstanceStepRequest");
        throw;
    }
}
public async object UpdateProcedureInstance_CommentDateRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.UpdateProcedureInstance_CommentDateRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateProcedureInstance_CommentDateRequest");
        throw;
    }
}
public async object UpdateProcedureInstance_MilesRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.UpdateProcedureInstance_MilesRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in UpdateProcedureInstance_MilesRequest");
        throw;
    }
}
public async object ViewProcedureInstanceRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.ViewProcedureInstanceRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in ViewProcedureInstanceRequest");
        throw;
    }
}
public async object ViewProcedureInstanceStepInstructor_EvalRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.ViewProcedureInstanceStepInstructor_EvalRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in ViewProcedureInstanceStepInstructor_EvalRequest");
        throw;
    }
}
public async object ViewProcedureInstance_EvalRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.ViewProcedureInstance_EvalRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in ViewProcedureInstance_EvalRequest");
        throw;
    }
}
public async object ViewProcedureSequenceRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.ViewProcedureSequenceRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in ViewProcedureSequenceRequest");
        throw;
    }
}
public async object WalletChangePasswordRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _EvalAPIService.WalletChangePasswordRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in WalletChangePasswordRequest");
        throw;
    }
}

    }
}
