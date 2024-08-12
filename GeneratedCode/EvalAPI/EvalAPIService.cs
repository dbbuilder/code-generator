using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using EvalAPI.DataAccess;
using EvalAPI.Models;

namespace EvalAPI.Business
{
    /// <summary>
    /// Service class for the EvalAPI namespace.
    /// </summary>
    public class EvalAPIService : IEvalAPIService
    {
        private readonly IEvalAPIService _repository;
        private readonly ILogger<EvalAPIService> _logger;

        public EvalAPIService(IEvalAPIService repository, ILogger<EvalAPIService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        Task AddEmployeeFileRequest();
Task AddProcedureInstanceHistoryRequest();
Task CheckInPersonEventRequest();
Task CheckInPersonRequest();
Task CheckOutPersonEvent();
Task CheckOutPersonRequest();
Task CreateProcedureInstanceRequest();
Task EmployeeTPRItem_Daily_GetListRequest();
Task EmployeeTimeCardItem_ApproveRequest();
Task EmployeeTimeCardItem_UpdateDateTimeOnlyRequest();
Task EmployeeTimeCardItem_UpdateRequest();
Task EmployeeTimeItem_GetListRequest();
Task EmployeeTimeItem_RemoveRequest();
Task EmployeeTimeItem_UpdateNoteRequest();
Task Employee_GetTimeCardIDRequest();
Task ForgotPassword_AppURLRequest();
Task GetClockStatusByProcedureSequenceID();
Task GetClockStatusRequest();
Task GetEventIDByProcedureSequenceID();
Task GetStudentRosterForTimeRequest();
Task Grade_GetCourseAndEventIDs_ByProcedureSequenceID();
Task GradingQueueResponse();
Task Grading_LinkEmployeeTimeCardItem_ProcedureInstanceRequest();
Task LinkProcedureInstance_InstructorRequest();
Task RemoveProcedureInstanceRequest();
Task SaveCompleteProcedureInstanceRequest();
Task SaveProcedureInstanceSignatureRequest();
Task SaveProcedureInstanceSignatureStudentRequest();
Task SelectAccountTransactionList_ByPersonRequest();
Task SelectAccumulatedCommentsRequest();
Task SelectAccumulatedTimeRequest();
Task SelectCertificateCourseRequest();
Task SelectCourseListRequest();
Task SelectEmployeeCriticalFailureCountRequest();
Task SelectEmployeeForTimeClockByCode();
Task SelectEmployeeJobEvalTimeClockRequest();
Task SelectEmployeeStatusListRequest();
Task SelectEmployeeTimeCardItemRequest();
Task SelectEmployeeTimeCardItems_OpenRequest();
Task SelectEvalCommentRequest();
Task SelectEventListRequest();
Task SelectGradeDataRequest();
Task SelectGradeData_EvalRequest();
Task SelectGradingQueueRequest();
Task SelectInstanceByStudentRequest();
Task SelectInstructorListRequest();
Task SelectInstructorLocationListRequest();
Task SelectLocationListRequest();
Task SelectLocationStationListRequest();
Task SelectMaxEvalBatch_ProcedureInstanceRequest();
Task SelectNewStudentDataRequest();
Task SelectOnboardTrackerDataRequest();
Task SelectPersonImageRequest();
Task SelectPersonTestTypeListRequest();
Task SelectPerson_TPRRequest();
Task SelectProcedureInstanceHistoryListRequest();
Task SelectProcedureInstanceList_byEvalBatchNumberRequest();
Task SelectProcedureInstanceList_byProcedureSequenceRequest();
Task SelectProcedureInstanceList_byProcedureSequence_CompletedRequest();
Task SelectProcedureInstanceSignatureRequest();
Task SelectProcedureSequenceFailureRulesRequest();
Task SelectProcedureSequenceListRequest();
Task SelectProcedureSequenceList_BatchEvalRequest();
Task SelectProcedureSequenceProficiencyRulesRequest();
Task SelectProcedureTypeEmployeeStatusListRequest();
Task SelectProcedureTypeListRequest();
Task SelectProcedureTypeList_ByJobRequest();
Task SelectProductListRequest();
Task SelectSponsorListRequest();
Task SelectStudentGroupListRequest();
Task SelectStudentListRequest();
Task SelectTPRDataRequest();
Task SelectTestDataRequest();
Task SelectTimeAndGradeDataRequest();
Task SelectTimeDataRequest();
Task SelectTimeItems_EvalRequest();
Task SelectTimeOffsetRequest();
Task SelectTruckTrackCertificateRequest();
Task SelectTruckTrackStudentRequest();
Task TPR_MarkAsUploadFailedRequest();
Task TPR_MarkAsUploadedRequest();
Task UnsubmitProcedureInstanceRequest();
Task UpdateEmployeeCriticalFailure();
Task UpdatePerson_TPRRequest();
Task UpdateProcedureInstanceDateTimeRequest();
Task UpdateProcedureInstanceRequest();
Task UpdateProcedureInstanceStepComponentRequest();
Task UpdateProcedureInstanceStepRequest();
Task UpdateProcedureInstance_CommentDateRequest();
Task UpdateProcedureInstance_MilesRequest();
Task ViewProcedureInstanceRequest();
Task ViewProcedureInstanceStepInstructor_EvalRequest();
Task ViewProcedureInstance_EvalRequest();
Task ViewProcedureSequenceRequest();
Task WalletChangePasswordRequest();

    }
}
