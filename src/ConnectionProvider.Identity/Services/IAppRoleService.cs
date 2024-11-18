using ConnectionProvider.Abstraction.Domain;
using ConnectionProvider.Identity.Model;
using Microsoft.AspNetCore.Identity;

namespace ConnectionProvider.Identity.Services
{
    public interface IAppRoleService 
    {
        Task<List<RoleModel>> GetRoleList();
    }
}