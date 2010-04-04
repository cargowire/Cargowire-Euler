using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Common
{
    public abstract class StringEulerItem : CacheEulerItem<string,string>, IEulerItem
    {
        public override string Solution
        {
            get { if (string.IsNullOrEmpty(_solution)) _solution = Calculate(out _timeTaken); return _solution; }
        }
        public override abstract string Calculate();
    }
}
