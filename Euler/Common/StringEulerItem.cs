using System;

namespace Cargowire.Euler.Common
{
    public abstract class StringEulerItem : BaseEulerItem<string, string>, IEulerItem
    {
        public StringEulerItem()
        {
        }

        public StringEulerItem(IProblemSolver<IEulerItem<string, string>, string> solver)
            : base(solver)
        {
        }
    }
}
