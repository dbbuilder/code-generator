using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using StudentTrackAPI.Models;

namespace StudentTrackAPI.DataAccess
{
    /// <summary>
    /// Repository class for the StudentTrackAPI namespace.
    /// </summary>
    public class StudentTrackAPIRepository : IStudentTrackAPIRepository
    {
        private readonly string _connectionString;
        private readonly ILogger<StudentTrackAPIRepository> _logger;

        public StudentTrackAPIRepository(IConfiguration configuration, ILogger<StudentTrackAPIRepository> logger)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _logger = logger;
        }

        public async Task<object> AddEmployeeNote()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("AddEmployeeNote", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<AddEmployeeNoteModel>();
                    while (reader.Read())
                    {
                        var obj = new AddEmployeeNoteModel();
                        foreach (var prop in typeof(AddEmployeeNoteModel).GetProperties())
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
public async Task<object> AddTimeItemNoteRequest()
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
                var result = new List<AddTimeItemNoteRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new AddTimeItemNoteRequestModel();
                        foreach (var prop in typeof(AddTimeItemNoteRequestModel).GetProperties())
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
public async Task<object> AdminLoginRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Club_AdminLogin2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<AdminLoginRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new AdminLoginRequestModel();
                        foreach (var prop in typeof(AdminLoginRequestModel).GetProperties())
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
public async Task<object> AdminLoginWithKeyRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Club_AdminLogin_WithKey", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<AdminLoginWithKeyRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new AdminLoginWithKeyRequestModel();
                        foreach (var prop in typeof(AdminLoginWithKeyRequestModel).GetProperties())
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
        using (var command = new SqlCommand("Club_CheckInPerson2", connection))
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
public async Task<object> CheckInPerson_InONLYRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Club_CheckInPerson_InONLY", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<CheckInPerson_InONLYRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new CheckInPerson_InONLYRequestModel();
                        foreach (var prop in typeof(CheckInPerson_InONLYRequestModel).GetProperties())
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
public async Task<object> CheckUniqueFieldRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("CheckUniqueField", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<CheckUniqueFieldRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new CheckUniqueFieldRequestModel();
                        foreach (var prop in typeof(CheckUniqueFieldRequestModel).GetProperties())
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
public async Task<object> Club_CheckOutPersonRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Club_CheckOutPerson", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<Club_CheckOutPersonRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new Club_CheckOutPersonRequestModel();
                        foreach (var prop in typeof(Club_CheckOutPersonRequestModel).GetProperties())
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
public async Task<object> GetEmployeeNoteByDate()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeNote_ByDate", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<GetEmployeeNoteByDateModel>();
                    while (reader.Read())
                    {
                        var obj = new GetEmployeeNoteByDateModel();
                        foreach (var prop in typeof(GetEmployeeNoteByDateModel).GetProperties())
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
public async Task<object> GetPersonForAdminRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Club_SelectPersonByCode2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<GetPersonForAdminRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new GetPersonForAdminRequestModel();
                        foreach (var prop in typeof(GetPersonForAdminRequestModel).GetProperties())
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
public async Task<object> GetPersonForCheckInRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Club_SelectPersonByCode2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<GetPersonForCheckInRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new GetPersonForCheckInRequestModel();
                        foreach (var prop in typeof(GetPersonForCheckInRequestModel).GetProperties())
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
public async Task<object> GetPersonList_NotEligibleRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeList_NotEventEligible", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<GetPersonList_NotEligibleRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new GetPersonList_NotEligibleRequestModel();
                        foreach (var prop in typeof(GetPersonList_NotEligibleRequestModel).GetProperties())
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
public async Task<object> LookupClubsRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Club_SelectClubList2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<LookupClubsRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new LookupClubsRequestModel();
                        foreach (var prop in typeof(LookupClubsRequestModel).GetProperties())
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
public async Task<object> SelectEmployeeBiography()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeBiography", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEmployeeBiographyModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEmployeeBiographyModel();
                        foreach (var prop in typeof(SelectEmployeeBiographyModel).GetProperties())
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
public async Task<object> SelectEmployeeID_BySSN()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeID_BySSN", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEmployeeID_BySSNModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEmployeeID_BySSNModel();
                        foreach (var prop in typeof(SelectEmployeeID_BySSNModel).GetProperties())
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
public async Task<object> SelectEmployeePeriodSchedule()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeePeriodScheduleList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEmployeePeriodScheduleModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEmployeePeriodScheduleModel();
                        foreach (var prop in typeof(SelectEmployeePeriodScheduleModel).GetProperties())
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
public async Task<object> SelectEmployeeSSN_ByID()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeSSN_ByID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEmployeeSSN_ByIDModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEmployeeSSN_ByIDModel();
                        foreach (var prop in typeof(SelectEmployeeSSN_ByIDModel).GetProperties())
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
public async Task<object> SelectLocationClockInRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectLocationClockIn", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectLocationClockInRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectLocationClockInRequestModel();
                        foreach (var prop in typeof(SelectLocationClockInRequestModel).GetProperties())
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
public async Task<object> Time_GetClockStatus_By_LocationIDRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Time_GetClockStatus_By_LocationID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<Time_GetClockStatus_By_LocationIDRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new Time_GetClockStatus_By_LocationIDRequestModel();
                        foreach (var prop in typeof(Time_GetClockStatus_By_LocationIDRequestModel).GetProperties())
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
public async Task<object> UpdateEmployeeBiography()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateEmployeeBiography", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateEmployeeBiographyModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateEmployeeBiographyModel();
                        foreach (var prop in typeof(UpdateEmployeeBiographyModel).GetProperties())
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
public async Task<object> UpdateEmployeeBiography_BySSN()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateEmployeeBiography_BySSN", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateEmployeeBiography_BySSNModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateEmployeeBiography_BySSNModel();
                        foreach (var prop in typeof(UpdateEmployeeBiography_BySSNModel).GetProperties())
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
public async Task<object> UpdateEmployeePeriodSchedule()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateEmployeePeriodSchedule", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateEmployeePeriodScheduleModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateEmployeePeriodScheduleModel();
                        foreach (var prop in typeof(UpdateEmployeePeriodScheduleModel).GetProperties())
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
public async Task<object> UpdateLogEntryRequest()
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
                var result = new List<UpdateLogEntryRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateLogEntryRequestModel();
                        foreach (var prop in typeof(UpdateLogEntryRequestModel).GetProperties())
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
public async Task<object> UpdatePersonEventEligibilityByCodeRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateEmployee_IsEventEligible_ByCode", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdatePersonEventEligibilityByCodeRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdatePersonEventEligibilityByCodeRequestModel();
                        foreach (var prop in typeof(UpdatePersonEventEligibilityByCodeRequestModel).GetProperties())
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
public async Task<object> UpdatePersonEventEligibilityBySSNRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateEmployee_IsEventEligible_BySSN", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdatePersonEventEligibilityBySSNRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdatePersonEventEligibilityBySSNRequestModel();
                        foreach (var prop in typeof(UpdatePersonEventEligibilityBySSNRequestModel).GetProperties())
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
public async Task<object> UpdatePersonEventEligibilityRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateEmployee_IsEventEligible", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdatePersonEventEligibilityRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdatePersonEventEligibilityRequestModel();
                        foreach (var prop in typeof(UpdatePersonEventEligibilityRequestModel).GetProperties())
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
public async Task<object> UpdatePersonRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdatePerson_StudentTrack", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdatePersonRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdatePersonRequestModel();
                        foreach (var prop in typeof(UpdatePersonRequestModel).GetProperties())
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
