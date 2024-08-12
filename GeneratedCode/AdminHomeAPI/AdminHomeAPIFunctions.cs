using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AdminHomeAPI.API
{
    public class AdminHomeAPIFunctions
    {
        private readonly ILogger<AdminHomeAPIFunctions> _logger;
        private readonly IAdminHomeAPIService _AdminHomeAPIService;

        public AdminHomeAPIFunctions(ILogger<AdminHomeAPIFunctions> logger, IAdminHomeAPIService AdminHomeAPIService)
        {
            _logger = logger;
            _AdminHomeAPIService = AdminHomeAPIService;
        }

        public async object AddAdminLinkRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _AdminHomeAPIService.AddAdminLinkRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in AddAdminLinkRequest");
        throw;
    }
}
public async object BadgeLogin2Request()
{
    try
    {
        // Assuming the service method has the same name
        return await _AdminHomeAPIService.BadgeLogin2Request();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in BadgeLogin2Request");
        throw;
    }
}
public async object DeleteAdminLinkRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _AdminHomeAPIService.DeleteAdminLinkRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in DeleteAdminLinkRequest");
        throw;
    }
}
public async object ForgotPassword_AppURLRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _AdminHomeAPIService.ForgotPassword_AppURLRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in ForgotPassword_AppURLRequest");
        throw;
    }
}
public async object SelectAdminLinksRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _AdminHomeAPIService.SelectAdminLinksRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectAdminLinksRequest");
        throw;
    }
}
public async object SelectPerson_AdminAccessRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _AdminHomeAPIService.SelectPerson_AdminAccessRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPerson_AdminAccessRequest");
        throw;
    }
}
public async object SelectPerson_ByEmailRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _AdminHomeAPIService.SelectPerson_ByEmailRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in SelectPerson_ByEmailRequest");
        throw;
    }
}
public async object WalletChangePasswordRequest()
{
    try
    {
        // Assuming the service method has the same name
        return await _AdminHomeAPIService.WalletChangePasswordRequest();
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error in WalletChangePasswordRequest");
        throw;
    }
}

    }
}
