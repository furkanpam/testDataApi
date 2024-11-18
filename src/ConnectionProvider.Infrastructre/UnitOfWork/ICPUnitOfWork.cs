using ConnectionProvider.Abstraction.Data.EfCore.UnitOfwork;
using ConnectionProvider.Domain.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Infrastructre.UnitOfWork
{
    public interface ICPUnitOfWork : IUnitOfWork<ConnectionProviderDbContext>
    {
    }
}
