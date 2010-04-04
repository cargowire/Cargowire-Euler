using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Common
{
    public abstract class LongEulerItem : CacheEulerItem<string,long>, IEulerItem
    {
        public override abstract long Calculate();
    }
}
