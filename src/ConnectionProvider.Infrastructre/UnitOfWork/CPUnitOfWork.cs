using ConnectionProvider.Abstraction.Attributes;
using ConnectionProvider.Abstraction.Enums;
using ConnectionProvider.Core.Data.UnitOfWork;
using ConnectionProvider.Domain.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Infrastructre.UnitOfWork
{
    [LifeCircle(LifeCircleTypes.Scoped)]
    public class CPUnitOfWork : UnitOfWork<ConnectionProviderDbContext>, ICPUnitOfWork
    {
        public CPUnitOfWork(ConnectionProviderDbContext context) : base(context)
        {
        }
    }
}
