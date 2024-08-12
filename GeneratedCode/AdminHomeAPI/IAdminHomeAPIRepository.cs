using System.Threading.Tasks;
using AdminHomeAPI.Models;

namespace AdminHomeAPI.DataAccess
{
    /// <summary>
    /// Defines the repository interface for the AdminHomeAPI namespace.
    /// </summary>
    public interface IAdminHomeAPIRepository
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
