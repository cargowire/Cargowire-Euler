using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cargowire.Euler.Common
{
    public interface IEulerItem<P,S> : IEulerItem
    {
        new S ConfirmedAnswer { get; }
        new P Problem { get; }
        new S Solution { get; }
        new S Calculate();
        new S Calculate(out TimeSpan timeTaken);
    }
}
