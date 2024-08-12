using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using BadgeAPI.Models;

namespace BadgeAPI.DataAccess
{
    /// <summary>
    /// Repository class for the BadgeAPI namespace.
    /// </summary>
    public class BadgeAPIRepository : IBadgeAPIRepository
    {
        private readonly string _connectionString;
        private readonly ILogger<BadgeAPIRepository> _logger;

        public BadgeAPIRepository(IConfiguration configuration, ILogger<BadgeAPIRepository> logger)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _logger = logger;
        }

        public async Task<object> AttachWalletToAccountRequest()
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
public async Task<object> BadgeAddEventRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_ViewTimeclockHistory", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeAddEventRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeAddEventRequestModel();
                        foreach (var prop in typeof(BadgeAddEventRequestModel).GetProperties())
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
public async Task<object> BadgeAddWalletAccountRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_AddWalletAndAccount", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeAddWalletAccountRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeAddWalletAccountRequestModel();
                        foreach (var prop in typeof(BadgeAddWalletAccountRequestModel).GetProperties())
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
public async Task<object> BadgeBulkUploadRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_BulkUploadFile", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeBulkUploadRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeBulkUploadRequestModel();
                        foreach (var prop in typeof(BadgeBulkUploadRequestModel).GetProperties())
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
public async Task<object> BadgeClockInRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_CheckOutPerson", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeClockInRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeClockInRequestModel();
                        foreach (var prop in typeof(BadgeClockInRequestModel).GetProperties())
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
public async Task<object> BadgeClockOutRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_CheckInPerson_Event", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeClockOutRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeClockOutRequestModel();
                        foreach (var prop in typeof(BadgeClockOutRequestModel).GetProperties())
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
public async Task<object> BadgeForgotPasswordRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SendForgotPasswordEmail", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeForgotPasswordRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeForgotPasswordRequestModel();
                        foreach (var prop in typeof(BadgeForgotPasswordRequestModel).GetProperties())
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
public async Task<object> BadgeGetImageBlobRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectImageBlob", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeGetImageBlobRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeGetImageBlobRequestModel();
                        foreach (var prop in typeof(BadgeGetImageBlobRequestModel).GetProperties())
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
public async Task<object> BadgeLogin2Request()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_Login2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeLogin2RequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeLogin2RequestModel();
                        foreach (var prop in typeof(BadgeLogin2RequestModel).GetProperties())
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
public async Task<object> BadgeLoginRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_Login", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeLoginRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeLoginRequestModel();
                        foreach (var prop in typeof(BadgeLoginRequestModel).GetProperties())
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
public async Task<object> BadgeLogin_AdminRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_Login_Admin", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeLogin_AdminRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeLogin_AdminRequestModel();
                        foreach (var prop in typeof(BadgeLogin_AdminRequestModel).GetProperties())
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
public async Task<object> BadgeLogin_ValidateRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_Login_Validate", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeLogin_ValidateRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeLogin_ValidateRequestModel();
                        foreach (var prop in typeof(BadgeLogin_ValidateRequestModel).GetProperties())
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
public async Task<object> BadgeLookupRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_Lookup", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeLookupRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeLookupRequestModel();
                        foreach (var prop in typeof(BadgeLookupRequestModel).GetProperties())
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
public async Task<object> BadgeSetupRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_Setup", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeSetupRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeSetupRequestModel();
                        foreach (var prop in typeof(BadgeSetupRequestModel).GetProperties())
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
public async Task<object> BadgeStoreImageBlobRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_StoreImageBlob", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<BadgeStoreImageBlobRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeStoreImageBlobRequestModel();
                        foreach (var prop in typeof(BadgeStoreImageBlobRequestModel).GetProperties())
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
public async Task<object> BadgeTimeclockHistoryRequest()
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
                var result = new List<BadgeTimeclockHistoryRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new BadgeTimeclockHistoryRequestModel();
                        foreach (var prop in typeof(BadgeTimeclockHistoryRequestModel).GetProperties())
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
public async Task<object> Badge_BadgeDesignID_GetDefaultValues()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_BadgeDesignID_GetDefaultValues", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<Badge_BadgeDesignID_GetDefaultValuesModel>();
                    while (reader.Read())
                    {
                        var obj = new Badge_BadgeDesignID_GetDefaultValuesModel();
                        foreach (var prop in typeof(Badge_BadgeDesignID_GetDefaultValuesModel).GetProperties())
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
public async Task<object> Badge_DismissBadgeAlertRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_DismissBadgeAlert", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<Badge_DismissBadgeAlertRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new Badge_DismissBadgeAlertRequestModel();
                        foreach (var prop in typeof(Badge_DismissBadgeAlertRequestModel).GetProperties())
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
public async Task<object> Badge_SendBadgeInvitation_BadgeIDRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SendBadgeInvitation_BadgeID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<Badge_SendBadgeInvitation_BadgeIDRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new Badge_SendBadgeInvitation_BadgeIDRequestModel();
                        foreach (var prop in typeof(Badge_SendBadgeInvitation_BadgeIDRequestModel).GetProperties())
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
public async Task<object> Badge_SendBadgeInvitation_BadgeID_ImportRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SendBadgeInvitation_AHEC_IDCard", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<Badge_SendBadgeInvitation_BadgeID_ImportRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new Badge_SendBadgeInvitation_BadgeID_ImportRequestModel();
                        foreach (var prop in typeof(Badge_SendBadgeInvitation_BadgeID_ImportRequestModel).GetProperties())
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
public async Task<object> Badge_SendMessage_BadgeIDRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SendMessage_BadgeID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<Badge_SendMessage_BadgeIDRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new Badge_SendMessage_BadgeIDRequestModel();
                        foreach (var prop in typeof(Badge_SendMessage_BadgeIDRequestModel).GetProperties())
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
public async Task<object> Badge_UpdateBadgeInformation_UserEditRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_UpdateBadgeInformation_UserEdit", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<Badge_UpdateBadgeInformation_UserEditRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new Badge_UpdateBadgeInformation_UserEditRequestModel();
                        foreach (var prop in typeof(Badge_UpdateBadgeInformation_UserEditRequestModel).GetProperties())
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
        using (var command = new SqlCommand("SelectAccountDue_ByPerson", connection))
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
public async Task<object> DeactivateDocumentRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectDocument", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<DeactivateDocumentRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new DeactivateDocumentRequestModel();
                        foreach (var prop in typeof(DeactivateDocumentRequestModel).GetProperties())
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
        using (var command = new SqlCommand("SelectDocumentList_ByLocation", connection))
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
public async Task<object> DocumentList_ByLocationRequest()
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
                var result = new List<DocumentList_ByLocationRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new DocumentList_ByLocationRequestModel();
                        foreach (var prop in typeof(DocumentList_ByLocationRequestModel).GetProperties())
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
public async Task<object> DocumentList_ExternalSignatureIncompleteRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateDocument_ExternalSigningComplete", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<DocumentList_ExternalSignatureIncompleteRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new DocumentList_ExternalSignatureIncompleteRequestModel();
                        foreach (var prop in typeof(DocumentList_ExternalSignatureIncompleteRequestModel).GetProperties())
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
        using (var command = new SqlCommand("Document_StoreDocument", connection))
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
public async Task<object> GetDocumentRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectDocument_ByExternalSignatureID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<GetDocumentRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new GetDocumentRequestModel();
                        foreach (var prop in typeof(GetDocumentRequestModel).GetProperties())
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
public async Task<object> GetDocument_ByExternalSignatureIDRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectDocumentList_ExternalSigningIncomplete", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<GetDocument_ByExternalSignatureIDRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new GetDocument_ByExternalSignatureIDRequestModel();
                        foreach (var prop in typeof(GetDocument_ByExternalSignatureIDRequestModel).GetProperties())
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
public async Task<object> PersonList3Request()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectPersonList4", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<PersonList3RequestModel>();
                    while (reader.Read())
                    {
                        var obj = new PersonList3RequestModel();
                        foreach (var prop in typeof(PersonList3RequestModel).GetProperties())
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
public async Task<object> PersonList4Request()
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
                var result = new List<PersonList4RequestModel>();
                    while (reader.Read())
                    {
                        var obj = new PersonList4RequestModel();
                        foreach (var prop in typeof(PersonList4RequestModel).GetProperties())
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
public async Task<object> PersonListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectPersonList3", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<PersonListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new PersonListRequestModel();
                        foreach (var prop in typeof(PersonListRequestModel).GetProperties())
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
public async Task<object> RefreshValidationBatchRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_RefreshBatch", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<RefreshValidationBatchRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new RefreshValidationBatchRequestModel();
                        foreach (var prop in typeof(RefreshValidationBatchRequestModel).GetProperties())
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
public async Task<object> SelectAccountDueByPersonRequest()
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
                var result = new List<SelectAccountDueByPersonRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectAccountDueByPersonRequestModel();
                        foreach (var prop in typeof(SelectAccountDueByPersonRequestModel).GetProperties())
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
        using (var command = new SqlCommand("UpdateWallet", connection))
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
public async Task<object> SelectBadgeAlertTemplateListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectBadgeAlertTemplateList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectBadgeAlertTemplateListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectBadgeAlertTemplateListRequestModel();
                        foreach (var prop in typeof(SelectBadgeAlertTemplateListRequestModel).GetProperties())
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
public async Task<object> SelectBadgeAlertsRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectBadgeAlert", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectBadgeAlertsRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectBadgeAlertsRequestModel();
                        foreach (var prop in typeof(SelectBadgeAlertsRequestModel).GetProperties())
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
public async Task<object> SelectBadgeContactsRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectBadgeInformationList_ByBadge", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectBadgeContactsRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectBadgeContactsRequestModel();
                        foreach (var prop in typeof(SelectBadgeContactsRequestModel).GetProperties())
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
public async Task<object> SelectBadgeDesignListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectBadgeDesignList2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectBadgeDesignListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectBadgeDesignListRequestModel();
                        foreach (var prop in typeof(SelectBadgeDesignListRequestModel).GetProperties())
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
public async Task<object> SelectBadgeDesignRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectBadgeDesign", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectBadgeDesignRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectBadgeDesignRequestModel();
                        foreach (var prop in typeof(SelectBadgeDesignRequestModel).GetProperties())
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
public async Task<object> SelectBadgeDesign_DefaultRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectBadgeDesign_Default", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectBadgeDesign_DefaultRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectBadgeDesign_DefaultRequestModel();
                        foreach (var prop in typeof(SelectBadgeDesign_DefaultRequestModel).GetProperties())
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
public async Task<object> SelectBadgeInformationListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectBadgeInformationList2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectBadgeInformationListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectBadgeInformationListRequestModel();
                        foreach (var prop in typeof(SelectBadgeInformationListRequestModel).GetProperties())
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
public async Task<object> SelectBadgeListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectBadgeList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectBadgeListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectBadgeListRequestModel();
                        foreach (var prop in typeof(SelectBadgeListRequestModel).GetProperties())
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
public async Task<object> SelectBadgeList_UsePersonIsActiveRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectBadgeList_UsePersonIsActive", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectBadgeList_UsePersonIsActiveRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectBadgeList_UsePersonIsActiveRequestModel();
                        foreach (var prop in typeof(SelectBadgeList_UsePersonIsActiveRequestModel).GetProperties())
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
public async Task<object> SelectBadgeMenuRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectBadgeMenuList_ByBadge", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectBadgeMenuRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectBadgeMenuRequestModel();
                        foreach (var prop in typeof(SelectBadgeMenuRequestModel).GetProperties())
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
public async Task<object> SelectClassListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectClassList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectClassListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectClassListRequestModel();
                        foreach (var prop in typeof(SelectClassListRequestModel).GetProperties())
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
public async Task<object> SelectDepartmentListRequest()
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
                var result = new List<SelectDepartmentListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectDepartmentListRequestModel();
                        foreach (var prop in typeof(SelectDepartmentListRequestModel).GetProperties())
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
        using (var command = new SqlCommand("Badge_CheckInPerson3", connection))
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
public async Task<object> SelectGuestByEmailRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateGuestActivation_ByEmployeeID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectGuestByEmailRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectGuestByEmailRequestModel();
                        foreach (var prop in typeof(SelectGuestByEmailRequestModel).GetProperties())
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
public async Task<object> SelectImageBatchRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_UpdateImage_ValidationScore", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectImageBatchRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectImageBatchRequestModel();
                        foreach (var prop in typeof(SelectImageBatchRequestModel).GetProperties())
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
public async Task<object> SelectInstitutionInfoRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectInstitutionInfo", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectInstitutionInfoRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectInstitutionInfoRequestModel();
                        foreach (var prop in typeof(SelectInstitutionInfoRequestModel).GetProperties())
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
public async Task<object> SelectLocationInfoRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectLocationInfo", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectLocationInfoRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectLocationInfoRequestModel();
                        foreach (var prop in typeof(SelectLocationInfoRequestModel).GetProperties())
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
        using (var command = new SqlCommand("Badge_SelectLocationList", connection))
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
public async Task<object> SelectMessageTemplateListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectMessageTemplate", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectMessageTemplateListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectMessageTemplateListRequestModel();
                        foreach (var prop in typeof(SelectMessageTemplateListRequestModel).GetProperties())
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
public async Task<object> SelectMessageTemplateTokenListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectMessageTemplateTokenList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectMessageTemplateTokenListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectMessageTemplateTokenListRequestModel();
                        foreach (var prop in typeof(SelectMessageTemplateTokenListRequestModel).GetProperties())
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
public async Task<object> SelectMessageTemplateTypeListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectMessageTemplateTypeList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectMessageTemplateTypeListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectMessageTemplateTypeListRequestModel();
                        foreach (var prop in typeof(SelectMessageTemplateTypeListRequestModel).GetProperties())
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
public async Task<object> SelectPersonRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectPerson", connection))
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
public async Task<object> SelectPersonRoleListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectEventList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectPersonRoleListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectPersonRoleListRequestModel();
                        foreach (var prop in typeof(SelectPersonRoleListRequestModel).GetProperties())
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
public async Task<object> SelectPersonStatusListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectDepartmentList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectPersonStatusListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectPersonStatusListRequestModel();
                        foreach (var prop in typeof(SelectPersonStatusListRequestModel).GetProperties())
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
public async Task<object> SelectRejectReasonListRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectBadgeRejectReasonList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectRejectReasonListRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectRejectReasonListRequestModel();
                        foreach (var prop in typeof(SelectRejectReasonListRequestModel).GetProperties())
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
public async Task<object> SelectValidationBatchRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectImageValidationBatch2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectValidationBatchRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectValidationBatchRequestModel();
                        foreach (var prop in typeof(SelectValidationBatchRequestModel).GetProperties())
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
public async Task<object> SendBadgeAlertRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SendBadgeAlertFromTemplate", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SendBadgeAlertRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SendBadgeAlertRequestModel();
                        foreach (var prop in typeof(SendBadgeAlertRequestModel).GetProperties())
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
        using (var command = new SqlCommand("Document_StoreDocumentSignature", connection))
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
public async Task<object> StoreDocumentSignatureRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Document_DeactivateDocument", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<StoreDocumentSignatureRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new StoreDocumentSignatureRequestModel();
                        foreach (var prop in typeof(StoreDocumentSignatureRequestModel).GetProperties())
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
        using (var command = new SqlCommand("UpdateLogEntry", connection))
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
        using (var command = new SqlCommand("Set_ARStatus_ByPerson", connection))
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
        using (var command = new SqlCommand("UpdateWallet_Account", connection))
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
public async Task<object> UpdateBadgeAlertTemplateRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_UpdateBadgeAlertTemplate", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateBadgeAlertTemplateRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateBadgeAlertTemplateRequestModel();
                        foreach (var prop in typeof(UpdateBadgeAlertTemplateRequestModel).GetProperties())
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
public async Task<object> UpdateBadgeDesignRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_UpdateBadgeDesign", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateBadgeDesignRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateBadgeDesignRequestModel();
                        foreach (var prop in typeof(UpdateBadgeDesignRequestModel).GetProperties())
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
public async Task<object> UpdateBadgeInformationRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_UpdateBadgeInformation", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateBadgeInformationRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateBadgeInformationRequestModel();
                        foreach (var prop in typeof(UpdateBadgeInformationRequestModel).GetProperties())
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
public async Task<object> UpdateDepartment_BadgeDesignID_Default()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_UpdateLocation_BadgeDesignID_Default", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateDepartment_BadgeDesignID_DefaultModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateDepartment_BadgeDesignID_DefaultModel();
                        foreach (var prop in typeof(UpdateDepartment_BadgeDesignID_DefaultModel).GetProperties())
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
public async Task<object> UpdateDocument_ExternalSigningCompleteRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectPersonList2", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateDocument_ExternalSigningCompleteRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateDocument_ExternalSigningCompleteRequestModel();
                        foreach (var prop in typeof(UpdateDocument_ExternalSigningCompleteRequestModel).GetProperties())
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
public async Task<object> UpdateGuestActivationByEmployeeIDRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateGuest_EmployeeID", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateGuestActivationByEmployeeIDRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateGuestActivationByEmployeeIDRequestModel();
                        foreach (var prop in typeof(UpdateGuestActivationByEmployeeIDRequestModel).GetProperties())
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
public async Task<object> UpdateGuestEmployeeIDRequest()
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
                var result = new List<UpdateGuestEmployeeIDRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateGuestEmployeeIDRequestModel();
                        foreach (var prop in typeof(UpdateGuestEmployeeIDRequestModel).GetProperties())
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
public async Task<object> UpdateImageScoreRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectPersonRoleList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateImageScoreRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateImageScoreRequestModel();
                        foreach (var prop in typeof(UpdateImageScoreRequestModel).GetProperties())
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
public async Task<object> UpdateInstitution_BadgeDesignID_Default()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_UpdateInstitution_BadgeDesignID_Default", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateInstitution_BadgeDesignID_DefaultModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateInstitution_BadgeDesignID_DefaultModel();
                        foreach (var prop in typeof(UpdateInstitution_BadgeDesignID_DefaultModel).GetProperties())
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
public async Task<object> UpdateLocation_BadgeDesignID_Default()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_UpdateLocation_BadgeDesignID_Default", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateLocation_BadgeDesignID_DefaultModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateLocation_BadgeDesignID_DefaultModel();
                        foreach (var prop in typeof(UpdateLocation_BadgeDesignID_DefaultModel).GetProperties())
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
        using (var command = new SqlCommand("SelectGuest_ByEmail", connection))
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
public async Task<object> UpdateMessageTemplateRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("UpdateMessageTemplate", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdateMessageTemplateRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdateMessageTemplateRequestModel();
                        foreach (var prop in typeof(UpdateMessageTemplateRequestModel).GetProperties())
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
        using (var command = new SqlCommand("CheckUniqueField", connection))
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
        using (var command = new SqlCommand("Badge_SelectPersonStatusList", connection))
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
public async Task<object> UpdatePhotoRequirementsRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_UpdatePhotoRequirements", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<UpdatePhotoRequirementsRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new UpdatePhotoRequirementsRequestModel();
                        foreach (var prop in typeof(UpdatePhotoRequirementsRequestModel).GetProperties())
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
        using (var command = new SqlCommand("UpdateAccount", connection))
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
public async Task<object> ValidateImageRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_ValidateImage", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<ValidateImageRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new ValidateImageRequestModel();
                        foreach (var prop in typeof(ValidateImageRequestModel).GetProperties())
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
public async Task<object> ValidationHelper()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_SelectImageScoringBatch", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<ValidationHelperModel>();
                    while (reader.Read())
                    {
                        var obj = new ValidationHelperModel();
                        foreach (var prop in typeof(ValidationHelperModel).GetProperties())
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
public async Task<object> ViewBadgeAlertLogRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("Badge_ViewBadgeAlertLog", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<ViewBadgeAlertLogRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new ViewBadgeAlertLogRequestModel();
                        foreach (var prop in typeof(ViewBadgeAlertLogRequestModel).GetProperties())
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
        using (var command = new SqlCommand("UpdatePerson", connection))
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
