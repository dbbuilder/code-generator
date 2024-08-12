using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using PersonAPI.Models;

namespace PersonAPI.DataAccess
{
    /// <summary>
    /// Repository class for the PersonAPI namespace.
    /// </summary>
    public class PersonAPIRepository : IPersonAPIRepository
    {
        private readonly string _connectionString;
        private readonly ILogger<PersonAPIRepository> _logger;

        public PersonAPIRepository(IConfiguration configuration, ILogger<PersonAPIRepository> logger)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _logger = logger;
        }

        public async Task<object> AddEmployeeFileRequest()
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
public async Task<object> AddPersonNoteRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("AddEmployeeNote2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<AddPersonNoteRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new AddPersonNoteRequestModel();
                        foreach (var prop in typeof(AddPersonNoteRequestModel).GetProperties())
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
public async Task<object> AddPersonTestRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("AddPersonTest", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<AddPersonTestRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new AddPersonTestRequestModel();
                        foreach (var prop in typeof(AddPersonTestRequestModel).GetProperties())
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
public async Task<object> AddTransactionRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("AddAdminTransaction2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<AddTransactionRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new AddTransactionRequestModel();
                        foreach (var prop in typeof(AddTransactionRequestModel).GetProperties())
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
public async Task<object> AttachWalletToAccountRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateWallet_Account", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<AttachWalletToAccountRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new AttachWalletToAccountRequestModel();
                        foreach (var prop in typeof(AttachWalletToAccountRequestModel).GetProperties())
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
public async Task<object> BadgeGenerateFileNameRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_GenerateImageFileName", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeGenerateFileNameRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeGenerateFileNameRequestModel();
                        foreach (var prop in typeof(BadgeGenerateFileNameRequestModel).GetProperties())
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
public async Task<object> BadgeSetupNewRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SetupNewBadge", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeSetupNewRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeSetupNewRequestModel();
                        foreach (var prop in typeof(BadgeSetupNewRequestModel).GetProperties())
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
public async Task<object> BadgeStoreImageRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_StoreImage", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeStoreImageRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeStoreImageRequestModel();
                        foreach (var prop in typeof(BadgeStoreImageRequestModel).GetProperties())
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
public async Task<object> DocumentListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectDocumentList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<DocumentListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new DocumentListRequestModel();
                        foreach (var prop in typeof(DocumentListRequestModel).GetProperties())
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
        using (var command = new SqlCommand("SendForgotPasswordEmail_ByAppURL", connection))
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
public async Task<object> GenerateDocumentFileNameRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Document_GenerateFileName", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<GenerateDocumentFileNameRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new GenerateDocumentFileNameRequestModel();
                        foreach (var prop in typeof(GenerateDocumentFileNameRequestModel).GetProperties())
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
public async Task<object> LookupPersonRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("LookupPerson", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<LookupPersonRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new LookupPersonRequestModel();
                        foreach (var prop in typeof(LookupPersonRequestModel).GetProperties())
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
public async Task<object> SelectAccountBadgeNumberRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectAccount_BadgeNumber", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectAccountBadgeNumberRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectAccountBadgeNumberRequestModel();
                        foreach (var prop in typeof(SelectAccountBadgeNumberRequestModel).GetProperties())
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
public async Task<object> SelectAccountListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectAccountList_ByFKID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectAccountListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectAccountListRequestModel();
                        foreach (var prop in typeof(SelectAccountListRequestModel).GetProperties())
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
        using (var command = new SqlCommand("SelectAccountTransactionList_ByPerson", connection))
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
public async Task<object> SelectAccountTransactionRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectAccountTransaction", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectAccountTransactionRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectAccountTransactionRequestModel();
                        foreach (var prop in typeof(SelectAccountTransactionRequestModel).GetProperties())
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
public async Task<object> SelectDocumentTypeProductRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectDocumentType_Product", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectDocumentTypeProductRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectDocumentTypeProductRequestModel();
                        foreach (var prop in typeof(SelectDocumentTypeProductRequestModel).GetProperties())
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
public async Task<object> SelectEmployeeSecurityAppItemListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeSecurityAppItemList_All", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEmployeeSecurityAppItemListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEmployeeSecurityAppItemListRequestModel();
                        foreach (var prop in typeof(SelectEmployeeSecurityAppItemListRequestModel).GetProperties())
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
        using (var command = new SqlCommand("SelectEmployeeStatusList", connection))
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
public async Task<object> SelectEmployeeStatusNewPersonRequiredFieldsListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeStatusNewPersonRequiredFieldsList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEmployeeStatusNewPersonRequiredFieldsListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEmployeeStatusNewPersonRequiredFieldsListRequestModel();
                        foreach (var prop in typeof(SelectEmployeeStatusNewPersonRequiredFieldsListRequestModel).GetProperties())
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
public async Task<object> SelectEmployee_EmployeeStatusRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployee_EmployeeStatus", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEmployee_EmployeeStatusRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEmployee_EmployeeStatusRequestModel();
                        foreach (var prop in typeof(SelectEmployee_EmployeeStatusRequestModel).GetProperties())
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
public async Task<object> SelectEmployee_MealPlanRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectMealPlan_ByPerson", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectEmployee_MealPlanRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectEmployee_MealPlanRequestModel();
                        foreach (var prop in typeof(SelectEmployee_MealPlanRequestModel).GetProperties())
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
        using (var command = new SqlCommand("Wallet_SelectLocationList", connection))
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
public async Task<object> SelectMealPlanListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectMealPlanList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectMealPlanListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectMealPlanListRequestModel();
                        foreach (var prop in typeof(SelectMealPlanListRequestModel).GetProperties())
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
public async Task<object> SelectPersonFileRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeFile ", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectPersonFileRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectPersonFileRequestModel();
                        foreach (var prop in typeof(SelectPersonFileRequestModel).GetProperties())
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
public async Task<object> SelectPersonInfoRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectPersonInfo", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectPersonInfoRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectPersonInfoRequestModel();
                        foreach (var prop in typeof(SelectPersonInfoRequestModel).GetProperties())
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
public async Task<object> SelectPersonNoteListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectEmployeeNote2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectPersonNoteListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectPersonNoteListRequestModel();
                        foreach (var prop in typeof(SelectPersonNoteListRequestModel).GetProperties())
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
public async Task<object> SelectPersonRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectPerson2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectPersonRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectPersonRequestModel();
                        foreach (var prop in typeof(SelectPersonRequestModel).GetProperties())
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
public async Task<object> SelectPersonTestListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectPersonTest", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectPersonTestListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectPersonTestListRequestModel();
                        foreach (var prop in typeof(SelectPersonTestListRequestModel).GetProperties())
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
        using (var command = new SqlCommand("SelectPersonTestType", connection))
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
public async Task<object> SelectPhotoRequirementsRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectPhotoRequirements", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectPhotoRequirementsRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectPhotoRequirementsRequestModel();
                        foreach (var prop in typeof(SelectPhotoRequirementsRequestModel).GetProperties())
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
        using (var command = new SqlCommand("Ecommerce_SelectProduct", connection))
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
public async Task<object> SelectProductTypeListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Ecommerce_SelectProductTypeList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectProductTypeListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectProductTypeListRequestModel();
                        foreach (var prop in typeof(SelectProductTypeListRequestModel).GetProperties())
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
public async Task<object> SelectRoleListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectDefaultRoleList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectRoleListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectRoleListRequestModel();
                        foreach (var prop in typeof(SelectRoleListRequestModel).GetProperties())
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
public async Task<object> SelectSecurityAppItemListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectSecurityAppItemList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectSecurityAppItemListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectSecurityAppItemListRequestModel();
                        foreach (var prop in typeof(SelectSecurityAppItemListRequestModel).GetProperties())
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
public async Task<object> SelectStateListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectStateList2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectStateListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectStateListRequestModel();
                        foreach (var prop in typeof(SelectStateListRequestModel).GetProperties())
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
        using (var command = new SqlCommand("SelectStudentGroupList", connection))
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
public async Task<object> SelectStudentGroupNewPersonRequiredFieldsListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectStudentGroupNewPersonRequiredFieldsList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectStudentGroupNewPersonRequiredFieldsListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectStudentGroupNewPersonRequiredFieldsListRequestModel();
                        foreach (var prop in typeof(SelectStudentGroupNewPersonRequiredFieldsListRequestModel).GetProperties())
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
public async Task<object> SelectTuitionPaymentTypeListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Select_TuitionPaymentType", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectTuitionPaymentTypeListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectTuitionPaymentTypeListRequestModel();
                        foreach (var prop in typeof(SelectTuitionPaymentTypeListRequestModel).GetProperties())
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
public async Task<object> SelectWalletListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectWalletList_ByFKID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectWalletListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectWalletListRequestModel();
                        foreach (var prop in typeof(SelectWalletListRequestModel).GetProperties())
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
public async Task<object> SetupProductSaleRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Ecommerce_SetupProductSaleTransaction", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SetupProductSaleRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SetupProductSaleRequestModel();
                        foreach (var prop in typeof(SetupProductSaleRequestModel).GetProperties())
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
public async Task<object> StoreDocumentRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Document_StoreDocument", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<StoreDocumentRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new StoreDocumentRequestModel();
                        foreach (var prop in typeof(StoreDocumentRequestModel).GetProperties())
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
public async Task<object> SyncAccountBadgeNumberRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SyncAccount_BadgeNumber", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SyncAccountBadgeNumberRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SyncAccountBadgeNumberRequestModel();
                        foreach (var prop in typeof(SyncAccountBadgeNumberRequestModel).GetProperties())
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
public async Task<object> SyncAccountRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SyncAccount", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SyncAccountRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SyncAccountRequestModel();
                        foreach (var prop in typeof(SyncAccountRequestModel).GetProperties())
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
public async Task<object> SyncEmployeeGuestRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SyncEmployee_Guest_ByEmployeeID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SyncEmployeeGuestRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SyncEmployeeGuestRequestModel();
                        foreach (var prop in typeof(SyncEmployeeGuestRequestModel).GetProperties())
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
public async Task<object> UpdateAccountRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateAccount", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateAccountRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateAccountRequestModel();
                        foreach (var prop in typeof(UpdateAccountRequestModel).GetProperties())
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
public async Task<object> UpdateAccountTransactionNoteRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateAccountTransaction_Note", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateAccountTransactionNoteRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateAccountTransactionNoteRequestModel();
                        foreach (var prop in typeof(UpdateAccountTransactionNoteRequestModel).GetProperties())
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
public async Task<object> UpdateAccountTransactionRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateAccountTransaction", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateAccountTransactionRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateAccountTransactionRequestModel();
                        foreach (var prop in typeof(UpdateAccountTransactionRequestModel).GetProperties())
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
public async Task<object> UpdateBadgeActivationRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_DeactivateBadge", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateBadgeActivationRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateBadgeActivationRequestModel();
                        foreach (var prop in typeof(UpdateBadgeActivationRequestModel).GetProperties())
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
public async Task<object> UpdateBadgeLocationRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_UpdateBadge_Location", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateBadgeLocationRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateBadgeLocationRequestModel();
                        foreach (var prop in typeof(UpdateBadgeLocationRequestModel).GetProperties())
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
public async Task<object> UpdateEmployeeSecurityAppItemRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateEmployeeSecurityAppItem", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateEmployeeSecurityAppItemRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateEmployeeSecurityAppItemRequestModel();
                        foreach (var prop in typeof(UpdateEmployeeSecurityAppItemRequestModel).GetProperties())
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
public async Task<object> UpdateEmployee_AddJob_NonDefaultRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateEmployee_EmployeeJob", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateEmployee_AddJob_NonDefaultRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateEmployee_AddJob_NonDefaultRequestModel();
                        foreach (var prop in typeof(UpdateEmployee_AddJob_NonDefaultRequestModel).GetProperties())
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
public async Task<object> UpdateEmployee_EmployeeStatusRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateEmployee_EmployeeStatus", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateEmployee_EmployeeStatusRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateEmployee_EmployeeStatusRequestModel();
                        foreach (var prop in typeof(UpdateEmployee_EmployeeStatusRequestModel).GetProperties())
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
public async Task<object> UpdateEmployee_JobRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateEmployeeDefaultJob", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateEmployee_JobRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateEmployee_JobRequestModel();
                        foreach (var prop in typeof(UpdateEmployee_JobRequestModel).GetProperties())
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
public async Task<object> UpdateEmployee_MealPlanRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateMealPlan_ByPerson", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateEmployee_MealPlanRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateEmployee_MealPlanRequestModel();
                        foreach (var prop in typeof(UpdateEmployee_MealPlanRequestModel).GetProperties())
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
public async Task<object> UpdateGuestByEmployeeIDRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateGuest_ByEmployeeID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateGuestByEmployeeIDRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateGuestByEmployeeIDRequestModel();
                        foreach (var prop in typeof(UpdateGuestByEmployeeIDRequestModel).GetProperties())
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
public async Task<object> UpdatePersonDetailsRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdatePerson_Details", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdatePersonDetailsRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdatePersonDetailsRequestModel();
                        foreach (var prop in typeof(UpdatePersonDetailsRequestModel).GetProperties())
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
        using (var command = new SqlCommand("UpdatePerson", connection))
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
public async Task<object> UpdatePersonTestRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdatePersonTest", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdatePersonTestRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdatePersonTestRequestModel();
                        foreach (var prop in typeof(UpdatePersonTestRequestModel).GetProperties())
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
public async Task<object> UpdatePerson_ActivationRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdatePerson_Activation", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdatePerson_ActivationRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdatePerson_ActivationRequestModel();
                        foreach (var prop in typeof(UpdatePerson_ActivationRequestModel).GetProperties())
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
public async Task<object> UpdatePerson_OptInRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdatePerson_OptIn", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdatePerson_OptInRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdatePerson_OptInRequestModel();
                        foreach (var prop in typeof(UpdatePerson_OptInRequestModel).GetProperties())
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
public async Task<object> UpdateStudent_IsActiveRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateStudent_IsActive", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateStudent_IsActiveRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateStudent_IsActiveRequestModel();
                        foreach (var prop in typeof(UpdateStudent_IsActiveRequestModel).GetProperties())
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
public async Task<object> UpdateWalletRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateWallet", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateWalletRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateWalletRequestModel();
                        foreach (var prop in typeof(UpdateWalletRequestModel).GetProperties())
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
        using (var command = new SqlCommand("Wallet_ChangePassword", connection))
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
public async Task<object> WalletLoginUserRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("WalletLogin3", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<WalletLoginUserRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new WalletLoginUserRequestModel();
                        foreach (var prop in typeof(WalletLoginUserRequestModel).GetProperties())
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
public async Task<object> WalletLoginUser_WithInstitutionGlobalKeyRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("WalletLogin5", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<WalletLoginUser_WithInstitutionGlobalKeyRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new WalletLoginUser_WithInstitutionGlobalKeyRequestModel();
                        foreach (var prop in typeof(WalletLoginUser_WithInstitutionGlobalKeyRequestModel).GetProperties())
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
