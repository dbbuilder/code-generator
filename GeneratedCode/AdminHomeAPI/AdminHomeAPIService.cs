using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using AdminHomeAPI.DataAccess;
using AdminHomeAPI.Models;

namespace AdminHomeAPI.Business
{
    /// <summary>
    /// Service class for the AdminHomeAPI namespace.
    /// </summary>
    public class AdminHomeAPIService : IAdminHomeAPIService
    {
        private readonly IAdminHomeAPIService _repository;
        private readonly ILogger<AdminHomeAPIService> _logger;

        public AdminHomeAPIService(IAdminHomeAPIService repository, ILogger<AdminHomeAPIService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        Task AddAdminLinkRequest();
Task BadgeLogin2Request();
Task DeleteAdminLinkRequest();
Task ForgotPassword_AppURLRequest();
Task SelectAdminLinksRequest();
Task SelectPerson_AdminAccessRequest();
Task SelectPerson_ByEmailRequest();
Task WalletChangePasswordRequest();

    }
}
