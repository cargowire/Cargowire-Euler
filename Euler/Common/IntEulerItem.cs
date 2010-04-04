using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Common
{
    public abstract class IntEulerItem : CacheEulerItem<string,int>, IEulerItem
    {
        public override abstract int Calculate();
    }
}
