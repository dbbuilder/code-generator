using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using EvalAPI.Models;

namespace EvalAPI.DataAccess
{
    /// <summary>
    /// Repository class for the EvalAPI namespace.
    /// </summary>
    public class EvalAPIRepository : IEvalAPIRepository
    {
        private readonly string _connectionString;
        private readonly ILogger<EvalAPIRepository> _logger;

        public EvalAPIRepository(IConfiguration configuration, ILogger<EvalAPIRepository> logger)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _logger = logger;
        }

        public async Task<object> AddEmployeeFileRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateEmployee_CriticalFailureCount", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<AddEmployeeFileRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new AddEmployeeFileRequestModel();
                        foreach (var prop in typeof(AddEmployeeFileRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> AddProcedureInstanceHistoryRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectProcedureInstanceHistoryList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<AddProcedureInstanceHistoryRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new AddProcedureInstanceHistoryRequestModel();
                        foreach (var prop in typeof(AddProcedureInstanceHistoryRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> CheckInPersonEventRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("RemoveProcedureInstance", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<CheckInPersonEventRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new CheckInPersonEventRequestModel();
                        foreach (var prop in typeof(CheckInPersonEventRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> CheckInPersonRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Time_CheckOutPerson", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<CheckInPersonRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new CheckInPersonRequestModel();
                        foreach (var prop in typeof(CheckInPersonRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> CheckOutPersonEvent()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Time_GetClockStatus_By_ProcedureSequenceID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<CheckOutPersonEventModel>();
                    while (reader.Read())
                    {
                        var obj = new CheckOutPersonEventModel();
                        foreach (var prop in typeof(CheckOutPersonEventModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> CheckOutPersonRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Time_CheckOutPerson_Event", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<CheckOutPersonRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new CheckOutPersonRequestModel();
                        foreach (var prop in typeof(CheckOutPersonRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> CreateProcedureInstanceRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("LinkProcedureInstance_Instructor2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<CreateProcedureInstanceRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new CreateProcedureInstanceRequestModel();
                        foreach (var prop in typeof(CreateProcedureInstanceRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> EmployeeTPRItem_Daily_GetListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("TPR_SelectNewData_Daily", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<EmployeeTPRItem_Daily_GetListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new EmployeeTPRItem_Daily_GetListRequestModel();
                        foreach (var prop in typeof(EmployeeTPRItem_Daily_GetListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> EmployeeTimeCardItem_ApproveRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("ApproveEmployeeTimeCardItem", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<EmployeeTimeCardItem_ApproveRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new EmployeeTimeCardItem_ApproveRequestModel();
                        foreach (var prop in typeof(EmployeeTimeCardItem_ApproveRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> EmployeeTimeCardItem_UpdateDateTimeOnlyRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateEmployeeTimeCardItemNote", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<EmployeeTimeCardItem_UpdateDateTimeOnlyRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new EmployeeTimeCardItem_UpdateDateTimeOnlyRequestModel();
                        foreach (var prop in typeof(EmployeeTimeCardItem_UpdateDateTimeOnlyRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> EmployeeTimeCardItem_UpdateRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("EditEmployeeTimeCardItem_DateTimes", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<EmployeeTimeCardItem_UpdateRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new EmployeeTimeCardItem_UpdateRequestModel();
                        foreach (var prop in typeof(EmployeeTimeCardItem_UpdateRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> EmployeeTimeItem_GetListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Web_ViewEmployeeTimeCardItemList_TruckTrack_TimeAdmin", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<EmployeeTimeItem_GetListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new EmployeeTimeItem_GetListRequestModel();
                        foreach (var prop in typeof(EmployeeTimeItem_GetListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> EmployeeTimeItem_RemoveRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("RemoveEmployeeTimeCardItem", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<EmployeeTimeItem_RemoveRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new EmployeeTimeItem_RemoveRequestModel();
                        foreach (var prop in typeof(EmployeeTimeItem_RemoveRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> EmployeeTimeItem_UpdateNoteRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateEmployeeTimeCardItemNote", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<EmployeeTimeItem_UpdateNoteRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new EmployeeTimeItem_UpdateNoteRequestModel();
                        foreach (var prop in typeof(EmployeeTimeItem_UpdateNoteRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> Employee_GetTimeCardIDRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("EditEmployeeTimeCardItem3", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<Employee_GetTimeCardIDRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new Employee_GetTimeCardIDRequestModel();
                        foreach (var prop in typeof(Employee_GetTimeCardIDRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> ForgotPassword_AppURLRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Time_SelectAccumulatedTime", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<ForgotPassword_AppURLRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new ForgotPassword_AppURLRequestModel();
                        foreach (var prop in typeof(ForgotPassword_AppURLRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> GetClockStatusByProcedureSequenceID()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Time_CheckInPerson_Event", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<GetClockStatusByProcedureSequenceIDModel>();
                    while (reader.Read())
                    {
                        var obj = new GetClockStatusByProcedureSequenceIDModel();
                        foreach (var prop in typeof(GetClockStatusByProcedureSequenceIDModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> GetClockStatusRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Time_SelectEventList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<GetClockStatusRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new GetClockStatusRequestModel();
                        foreach (var prop in typeof(GetClockStatusRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> GetEventIDByProcedureSequenceID()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectMaxEvalBatch_ProcedureInstance", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<GetEventIDByProcedureSequenceIDModel>();
                    while (reader.Read())
                    {
                        var obj = new GetEventIDByProcedureSequenceIDModel();
                        foreach (var prop in typeof(GetEventIDByProcedureSequenceIDModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> GetStudentRosterForTimeRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Time_CheckInPerson3", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<GetStudentRosterForTimeRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new GetStudentRosterForTimeRequestModel();
                        foreach (var prop in typeof(GetStudentRosterForTimeRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> Grade_GetCourseAndEventIDs_ByProcedureSequenceID()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Grade_GetEventID_ByProcedureSequenceID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<Grade_GetCourseAndEventIDs_ByProcedureSequenceIDModel>();
                    while (reader.Read())
                    {
                        var obj = new Grade_GetCourseAndEventIDs_ByProcedureSequenceIDModel();
                        foreach (var prop in typeof(Grade_GetCourseAndEventIDs_ByProcedureSequenceIDModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> GradingQueueResponse()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Time_GetClockStatus", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<GradingQueueResponseModel>();
                    while (reader.Read())
                    {
                        var obj = new GradingQueueResponseModel();
                        foreach (var prop in typeof(GradingQueueResponseModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> Grading_LinkEmployeeTimeCardItem_ProcedureInstanceRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEvalComment", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<Grading_LinkEmployeeTimeCardItem_ProcedureInstanceRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new Grading_LinkEmployeeTimeCardItem_ProcedureInstanceRequestModel();
                        foreach (var prop in typeof(Grading_LinkEmployeeTimeCardItem_ProcedureInstanceRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> LinkProcedureInstance_InstructorRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SaveCompleteProcedureInstance", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<LinkProcedureInstance_InstructorRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new LinkProcedureInstance_InstructorRequestModel();
                        foreach (var prop in typeof(LinkProcedureInstance_InstructorRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> RemoveProcedureInstanceRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("ViewProcedureSequence", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<RemoveProcedureInstanceRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new RemoveProcedureInstanceRequestModel();
                        foreach (var prop in typeof(RemoveProcedureInstanceRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SaveCompleteProcedureInstanceRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UnsubmitProcedureInstance", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SaveCompleteProcedureInstanceRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SaveCompleteProcedureInstanceRequestModel();
                        foreach (var prop in typeof(SaveCompleteProcedureInstanceRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SaveProcedureInstanceSignatureRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateProcedureInstance_Signature_Student", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SaveProcedureInstanceSignatureRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SaveProcedureInstanceSignatureRequestModel();
                        foreach (var prop in typeof(SaveProcedureInstanceSignatureRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SaveProcedureInstanceSignatureStudentRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectPersonImage", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SaveProcedureInstanceSignatureStudentRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SaveProcedureInstanceSignatureStudentRequestModel();
                        foreach (var prop in typeof(SaveProcedureInstanceSignatureStudentRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectAccountTransactionList_ByPersonRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectProductListForAdmin3", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectAccountTransactionList_ByPersonRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectAccountTransactionList_ByPersonRequestModel();
                        foreach (var prop in typeof(SelectAccountTransactionList_ByPersonRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectAccumulatedCommentsRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectPerson_TPR", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectAccumulatedCommentsRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectAccumulatedCommentsRequestModel();
                        foreach (var prop in typeof(SelectAccumulatedCommentsRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectAccumulatedTimeRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectStudentGroupList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectAccumulatedTimeRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectAccumulatedTimeRequestModel();
                        foreach (var prop in typeof(SelectAccumulatedTimeRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectCertificateCourseRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Time_SelectRoster", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectCertificateCourseRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectCertificateCourseRequestModel();
                        foreach (var prop in typeof(SelectCertificateCourseRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectCourseListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectCertificateCourse", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectCourseListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectCourseListRequestModel();
                        foreach (var prop in typeof(SelectCourseListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectEmployeeCriticalFailureCountRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("AddProcedureInstanceHistory", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEmployeeCriticalFailureCountRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEmployeeCriticalFailureCountRequestModel();
                        foreach (var prop in typeof(SelectEmployeeCriticalFailureCountRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectEmployeeForTimeClockByCode()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeForTimeClock_ByCode3", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEmployeeForTimeClockByCodeModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEmployeeForTimeClockByCodeModel();
                        foreach (var prop in typeof(SelectEmployeeForTimeClockByCodeModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectEmployeeJobEvalTimeClockRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeJobEvalTimeClock", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEmployeeJobEvalTimeClockRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEmployeeJobEvalTimeClockRequestModel();
                        foreach (var prop in typeof(SelectEmployeeJobEvalTimeClockRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectEmployeeStatusListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateLogEntry", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEmployeeStatusListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEmployeeStatusListRequestModel();
                        foreach (var prop in typeof(SelectEmployeeStatusListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectEmployeeTimeCardItemRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Web_ViewEmployeeTimeCardItemList_TruckTrack2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEmployeeTimeCardItemRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEmployeeTimeCardItemRequestModel();
                        foreach (var prop in typeof(SelectEmployeeTimeCardItemRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectEmployeeTimeCardItems_OpenRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeTimeCardItems_Open", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEmployeeTimeCardItems_OpenRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEmployeeTimeCardItems_OpenRequestModel();
                        foreach (var prop in typeof(SelectEmployeeTimeCardItems_OpenRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectEvalCommentRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("TruckTrack_GetTimeAndGradeData_ByStudent", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEvalCommentRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEvalCommentRequestModel();
                        foreach (var prop in typeof(SelectEvalCommentRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectEventListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeJobList_ByInstructor", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEventListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEventListRequestModel();
                        foreach (var prop in typeof(SelectEventListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectGradeDataRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectProcedureInstance_ByStudent", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectGradeDataRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectGradeDataRequestModel();
                        foreach (var prop in typeof(SelectGradeDataRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectGradeData_EvalRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("TruckTrack_GetTimeAndGradeData_ByStudent", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectGradeData_EvalRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectGradeData_EvalRequestModel();
                        foreach (var prop in typeof(SelectGradeData_EvalRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectGradingQueueRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectGradingQueue_Eval", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectGradingQueueRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectGradingQueueRequestModel();
                        foreach (var prop in typeof(SelectGradingQueueRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectInstanceByStudentRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("TruckTrack_GetTimeAndGradeData_ByStudent", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectInstanceByStudentRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectInstanceByStudentRequestModel();
                        foreach (var prop in typeof(SelectInstanceByStudentRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectInstructorListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectInstructorList2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectInstructorListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectInstructorListRequestModel();
                        foreach (var prop in typeof(SelectInstructorListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectInstructorLocationListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectInstructor_Location", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectInstructorLocationListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectInstructorLocationListRequestModel();
                        foreach (var prop in typeof(SelectInstructorLocationListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectLocationListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectLocationList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectLocationListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectLocationListRequestModel();
                        foreach (var prop in typeof(SelectLocationListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectLocationStationListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectLocationStationList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectLocationStationListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectLocationStationListRequestModel();
                        foreach (var prop in typeof(SelectLocationStationListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectMaxEvalBatch_ProcedureInstanceRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectProcedureInstanceList_byEvalBatchNumber", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectMaxEvalBatch_ProcedureInstanceRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectMaxEvalBatch_ProcedureInstanceRequestModel();
                        foreach (var prop in typeof(SelectMaxEvalBatch_ProcedureInstanceRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectNewStudentDataRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("TruckTrack_GetStudent", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectNewStudentDataRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectNewStudentDataRequestModel();
                        foreach (var prop in typeof(SelectNewStudentDataRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectOnboardTrackerDataRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("TruckTrack_GetTestData", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectOnboardTrackerDataRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectOnboardTrackerDataRequestModel();
                        foreach (var prop in typeof(SelectOnboardTrackerDataRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectPersonImageRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeTimeCardItem", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectPersonImageRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectPersonImageRequestModel();
                        foreach (var prop in typeof(SelectPersonImageRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectPersonTestTypeListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("TPR_SelectReport", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectPersonTestTypeListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectPersonTestTypeListRequestModel();
                        foreach (var prop in typeof(SelectPersonTestTypeListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectPerson_TPRRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdatePerson_TPR", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectPerson_TPRRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectPerson_TPRRequestModel();
                        foreach (var prop in typeof(SelectPerson_TPRRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectProcedureInstanceHistoryListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectAccountTransactionList_ByPerson", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectProcedureInstanceHistoryListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectProcedureInstanceHistoryListRequestModel();
                        foreach (var prop in typeof(SelectProcedureInstanceHistoryListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectProcedureInstanceList_byEvalBatchNumberRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectProcedureInstanceList_byProcedureSequence", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectProcedureInstanceList_byEvalBatchNumberRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectProcedureInstanceList_byEvalBatchNumberRequestModel();
                        foreach (var prop in typeof(SelectProcedureInstanceList_byEvalBatchNumberRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectProcedureInstanceList_byProcedureSequenceRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectProcedureInstanceList_byProcedureSequence_Completed", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectProcedureInstanceList_byProcedureSequenceRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectProcedureInstanceList_byProcedureSequenceRequestModel();
                        foreach (var prop in typeof(SelectProcedureInstanceList_byProcedureSequenceRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectProcedureInstanceList_byProcedureSequence_CompletedRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("ViewProcedureInstance", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectProcedureInstanceList_byProcedureSequence_CompletedRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectProcedureInstanceList_byProcedureSequence_CompletedRequestModel();
                        foreach (var prop in typeof(SelectProcedureInstanceList_byProcedureSequence_CompletedRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectProcedureInstanceSignatureRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateProcedureInstance_Signature", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectProcedureInstanceSignatureRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectProcedureInstanceSignatureRequestModel();
                        foreach (var prop in typeof(SelectProcedureInstanceSignatureRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectProcedureSequenceFailureRulesRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectProcedureSequenceProficiencyRules", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectProcedureSequenceFailureRulesRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectProcedureSequenceFailureRulesRequestModel();
                        foreach (var prop in typeof(SelectProcedureSequenceFailureRulesRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectProcedureSequenceListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectProcedureSequenceList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectProcedureSequenceListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectProcedureSequenceListRequestModel();
                        foreach (var prop in typeof(SelectProcedureSequenceListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectProcedureSequenceList_BatchEvalRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectProcedureSequenceList_BatchEval", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectProcedureSequenceList_BatchEvalRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectProcedureSequenceList_BatchEvalRequestModel();
                        foreach (var prop in typeof(SelectProcedureSequenceList_BatchEvalRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectProcedureSequenceProficiencyRulesRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("AddEmployeeFile", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectProcedureSequenceProficiencyRulesRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectProcedureSequenceProficiencyRulesRequestModel();
                        foreach (var prop in typeof(SelectProcedureSequenceProficiencyRulesRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectProcedureTypeEmployeeStatusListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectProcedureType_EmployeeStatusList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectProcedureTypeEmployeeStatusListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectProcedureTypeEmployeeStatusListRequestModel();
                        foreach (var prop in typeof(SelectProcedureTypeEmployeeStatusListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectProcedureTypeListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectProcedureTypeList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectProcedureTypeListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectProcedureTypeListRequestModel();
                        foreach (var prop in typeof(SelectProcedureTypeListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectProcedureTypeList_ByJobRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectProcedureTypeList_ByEmployeeJob", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectProcedureTypeList_ByJobRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectProcedureTypeList_ByJobRequestModel();
                        foreach (var prop in typeof(SelectProcedureTypeList_ByJobRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectProductListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectSalonTimeOffset_API", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectProductListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectProductListRequestModel();
                        foreach (var prop in typeof(SelectProductListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectSponsorListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectSponsorList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectSponsorListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectSponsorListRequestModel();
                        foreach (var prop in typeof(SelectSponsorListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectStudentGroupListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeStatusList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectStudentGroupListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectStudentGroupListRequestModel();
                        foreach (var prop in typeof(SelectStudentGroupListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectStudentListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectStudentList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectStudentListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectStudentListRequestModel();
                        foreach (var prop in typeof(SelectStudentListRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectTPRDataRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectProcedureSequenceFailureRules", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectTPRDataRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectTPRDataRequestModel();
                        foreach (var prop in typeof(SelectTPRDataRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectTestDataRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectPersonTestType", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectTestDataRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectTestDataRequestModel();
                        foreach (var prop in typeof(SelectTestDataRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectTimeAndGradeDataRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("TruckTrack_GetNewStudentData", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectTimeAndGradeDataRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectTimeAndGradeDataRequestModel();
                        foreach (var prop in typeof(SelectTimeAndGradeDataRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectTimeDataRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("TruckTrack_GetTimeAndGradeData_ByStudent", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectTimeDataRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectTimeDataRequestModel();
                        foreach (var prop in typeof(SelectTimeDataRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectTimeItems_EvalRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectTimeItems_Eval", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectTimeItems_EvalRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectTimeItems_EvalRequestModel();
                        foreach (var prop in typeof(SelectTimeItems_EvalRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectTimeOffsetRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Wallet_ChangePassword", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectTimeOffsetRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectTimeOffsetRequestModel();
                        foreach (var prop in typeof(SelectTimeOffsetRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectTruckTrackCertificateRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("TruckTrack_GetOnboardTrackerData", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectTruckTrackCertificateRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectTruckTrackCertificateRequestModel();
                        foreach (var prop in typeof(SelectTruckTrackCertificateRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectTruckTrackStudentRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("TruckTrack_GetCertificate", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectTruckTrackStudentRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectTruckTrackStudentRequestModel();
                        foreach (var prop in typeof(SelectTruckTrackStudentRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> TPR_MarkAsUploadFailedRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("TPR_MarkAsUploadFailed", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<TPR_MarkAsUploadFailedRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new TPR_MarkAsUploadFailedRequestModel();
                        foreach (var prop in typeof(TPR_MarkAsUploadFailedRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> TPR_MarkAsUploadedRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("TPR_MarkAsUploaded", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<TPR_MarkAsUploadedRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new TPR_MarkAsUploadedRequestModel();
                        foreach (var prop in typeof(TPR_MarkAsUploadedRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> UnsubmitProcedureInstanceRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Grade_SelectAccumulatedComments_ByProcedure2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UnsubmitProcedureInstanceRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UnsubmitProcedureInstanceRequestModel();
                        foreach (var prop in typeof(UnsubmitProcedureInstanceRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> UpdateEmployeeCriticalFailure()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployee_CriticalFailureCount", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateEmployeeCriticalFailureModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateEmployeeCriticalFailureModel();
                        foreach (var prop in typeof(UpdateEmployeeCriticalFailureModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> UpdatePerson_TPRRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectProcedureInstance_Signature", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdatePerson_TPRRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdatePerson_TPRRequestModel();
                        foreach (var prop in typeof(UpdatePerson_TPRRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> UpdateProcedureInstanceDateTimeRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("CreateProcedureInstance", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateProcedureInstanceDateTimeRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateProcedureInstanceDateTimeRequestModel();
                        foreach (var prop in typeof(UpdateProcedureInstanceDateTimeRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> UpdateProcedureInstanceRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateProcedureInstance_CommentDate", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateProcedureInstanceRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateProcedureInstanceRequestModel();
                        foreach (var prop in typeof(UpdateProcedureInstanceRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> UpdateProcedureInstanceStepComponentRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateProcedureInstance_ByID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateProcedureInstanceStepComponentRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateProcedureInstanceStepComponentRequestModel();
                        foreach (var prop in typeof(UpdateProcedureInstanceStepComponentRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> UpdateProcedureInstanceStepRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateProcedureInstanceStepComponent", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateProcedureInstanceStepRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateProcedureInstanceStepRequestModel();
                        foreach (var prop in typeof(UpdateProcedureInstanceStepRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> UpdateProcedureInstance_CommentDateRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateProcedureInstance_Miles", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateProcedureInstance_CommentDateRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateProcedureInstance_CommentDateRequestModel();
                        foreach (var prop in typeof(UpdateProcedureInstance_CommentDateRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> UpdateProcedureInstance_MilesRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateProcedureInstance_DateTime", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateProcedureInstance_MilesRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateProcedureInstance_MilesRequestModel();
                        foreach (var prop in typeof(UpdateProcedureInstance_MilesRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> ViewProcedureInstanceRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("ViewProcedureInstance_Eval", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<ViewProcedureInstanceRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new ViewProcedureInstanceRequestModel();
                        foreach (var prop in typeof(ViewProcedureInstanceRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> ViewProcedureInstanceStepInstructor_EvalRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateProcedureInstanceStep", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<ViewProcedureInstanceStepInstructor_EvalRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new ViewProcedureInstanceStepInstructor_EvalRequestModel();
                        foreach (var prop in typeof(ViewProcedureInstanceStepInstructor_EvalRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> ViewProcedureInstance_EvalRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("ViewProcedureInstanceStepIntructor_Eval", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<ViewProcedureInstance_EvalRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new ViewProcedureInstance_EvalRequestModel();
                        foreach (var prop in typeof(ViewProcedureInstance_EvalRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> ViewProcedureSequenceRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Grade_GetCourseAndEventIDs_ByProcedureSequenceID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<ViewProcedureSequenceRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new ViewProcedureSequenceRequestModel();
                        foreach (var prop in typeof(ViewProcedureSequenceRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> WalletChangePasswordRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SendForgotPasswordEmail_ByAppURL", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<WalletChangePasswordRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new WalletChangePasswordRequestModel();
                        foreach (var prop in typeof(WalletChangePasswordRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}

    }
}
