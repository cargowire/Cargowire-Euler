using System;

namespace Cargowire.Euler.Common
{
    public abstract class DoubleEulerItem : BaseEulerItem<string, double>, IEulerItem
    {
        public DoubleEulerItem()
        {
        }

        public DoubleEulerItem(IProblemSolver<IEulerItem<string, double>, double> solver)
            : base(solver)
        {
        }
    }
}
