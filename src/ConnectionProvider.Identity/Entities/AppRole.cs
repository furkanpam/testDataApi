using ConnectionProvider.Abstraction.Domain;
using Microsoft.AspNetCore.Identity;

namespace ConnectionProvider.Identity.Entities
{
    public class AppRole : IdentityRole<long>, IBaseEntity
    {
    }
}
