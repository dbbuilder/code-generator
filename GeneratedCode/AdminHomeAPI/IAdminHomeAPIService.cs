using System.Threading.Tasks;
using AdminHomeAPI.Models;

namespace AdminHomeAPI.Business
{
    /// <summary>
    /// Defines the service interface for the AdminHomeAPI namespace.
    /// </summary>
    public interface IAdminHomeAPIService
    {
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
