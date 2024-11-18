using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionProvider.Abstraction.Enums;

namespace ConnectionProvider.Abstraction.Attributes
{
    public class LifeCircleAttribute : Attribute
    {
        public LifeCircleAttribute(LifeCircleTypes LifeCircleTypes)
        {
            this.LifeCircleTypes = LifeCircleTypes;
        }
        public LifeCircleTypes LifeCircleTypes { get; set; }
    }
}
