using System;

namespace Cargowire.Euler.Common
{
    public abstract class LongEulerItem : BaseEulerItem<string, long>, IEulerItem
    {
        public LongEulerItem()
        {
        }

        public LongEulerItem(IProblemSolver<IEulerItem<string, long>, long> solver)
            : base(solver)
        {
        }
    }
}
