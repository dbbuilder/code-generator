using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using AdminHomeAPI.Models;

namespace AdminHomeAPI.DataAccess
{
    /// <summary>
    /// Repository class for the AdminHomeAPI namespace.
    /// </summary>
    public class AdminHomeAPIRepository : IAdminHomeAPIRepository
    {
        private readonly string _connectionString;
        private readonly ILogger<AdminHomeAPIRepository> _logger;

        public AdminHomeAPIRepository(IConfiguration configuration, ILogger<AdminHomeAPIRepository> logger)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _logger = logger;
        }

        public async Task<object> AddAdminLinkRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("AddAdminLink", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<AddAdminLinkRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new AddAdminLinkRequestModel();
                        foreach (var prop in typeof(AddAdminLinkRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
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
public async Task<object> DeleteAdminLinkRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("DeleteAdminLink", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<DeleteAdminLinkRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new DeleteAdminLinkRequestModel();
                        foreach (var prop in typeof(DeleteAdminLinkRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
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
public async Task<object> SelectAdminLinksRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectAdminLinkList", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectAdminLinksRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectAdminLinksRequestModel();
                        foreach (var prop in typeof(SelectAdminLinksRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectPerson_AdminAccessRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectPerson_AdminAccess", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectPerson_AdminAccessRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectPerson_AdminAccessRequestModel();
                        foreach (var prop in typeof(SelectPerson_AdminAccessRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
                            }
                        }
                        result.Add(obj);
                    }
                    return result;
            }
        }
    }
}
public async Task<object> SelectPerson_ByEmailRequest()
{
    using (var connection = new SqlConnection(_connectionString))
    {
        using (var command = new SqlCommand("SelectPerson_byEmail", connection))
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                var result = new List<SelectPerson_ByEmailRequestModel>();
                    while (reader.Read())
                    {
                        var obj = new SelectPerson_ByEmailRequestModel();
                        foreach (var prop in typeof(SelectPerson_ByEmailRequestModel).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                prop.SetValue(obj, reader[prop.Name]);
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

    }
}
