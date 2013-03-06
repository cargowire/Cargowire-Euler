using System;

namespace Cargowire.Euler.Common
{
    public abstract class IntEulerItem : BaseEulerItem<string, int>, IEulerItem
    {
        public IntEulerItem()
        {
        }

        public IntEulerItem(IProblemSolver<IEulerItem<string, int>, int> solver)
            : base(solver)
        {
        }
    }
}
