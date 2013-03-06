using System;

namespace Cargowire.Euler.Common
{
    public abstract class BaseEulerItem<TProblem, TSolution> 
        : IEulerItem<TProblem, TSolution>, IEulerItem
    {
        protected IProblemSolver<IEulerItem<TProblem, TSolution>, TSolution> _solver;
        
        public virtual TSolution ConfirmedAnswer { get { throw new NotImplementedException("Answer unknown"); } }
        public abstract TProblem Problem { get; }
        public virtual TSolution Solution
        {
            get { return _solver.Solution; }
        }

        public BaseEulerItem()
        {
        }

        public BaseEulerItem(IProblemSolver<IEulerItem<TProblem, TSolution>, TSolution> solver)
        {
            _solver = solver;
        }

        public TSolution Calculate(out TimeSpan timeTaken) 
        {
            return _solver.Calculate(out timeTaken);
        }

        public TSolution Calculate()
        {
            return _solver.Calculate();
        }
        
        public virtual string ShowWorkings(bool debug)
        {
            return _solver.ShowWorkings(debug);
        }

        public virtual string ShowWorkings(bool debug, out TimeSpan timeTaken)
        {
            return _solver.ShowWorkings(debug, out timeTaken);
        }

        public bool ValidSolution()
        {
            try
            {
                return ConfirmedAnswer.Equals(Solution);
            }
            catch(NotImplementedException)
            {
                return false;
            }
        }
        
        #region IEulerItem Members

        object IEulerItem.ConfirmedAnswer
        {
            get { return ConfirmedAnswer; }
        }
        object IEulerItem.Problem
        {
            get { return Problem; }
        }

        object IEulerItem.Solution
        {
            get { return Solution; }
        }

        object IEulerItem.Calculate()
        {
            return Calculate();
        }

        object IEulerItem.Calculate(out TimeSpan timeTaken)
        {
            return Calculate(out timeTaken);
        }

        #endregion
    }
}
