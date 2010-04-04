using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cargowire.Euler.Common
{
    public abstract class DoubleEulerItem : CacheEulerItem<string,double>, IEulerItem
    {
        public override abstract double Calculate();
    }
}
