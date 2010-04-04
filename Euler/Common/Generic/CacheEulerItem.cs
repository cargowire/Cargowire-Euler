using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Common
{
    public abstract class CacheEulerItem<T,S> : IEulerItem<T,S>, IEulerItem
    {
        protected S _solution = default(S);
        protected string _workings = string.Empty;
        protected string _debugWorkings = string.Empty;
        protected TimeSpan _timeTaken;

        public virtual S ConfirmedAnswer { get { throw new NotImplementedException("Answer unknown"); } }
        public abstract T Problem { get; }
        public virtual S Solution
        {
            get { if(_solution.Equals(default(S))) _solution = Calculate(out _timeTaken); return _solution; }
        }
        public S Calculate(out TimeSpan timeTaken) {
            DateTime start = DateTime.Now;
            S result = Calculate();
            timeTaken = DateTime.Now - start;
            return result;
        }
        public abstract S Calculate();
        
        public virtual string ShowWorkings(bool debug){
            return Solution.ToString(); // Solution is cached timed result
        }
        public virtual string ShowWorkings(bool debug, out TimeSpan timeTaken)
        {
            string result = ShowWorkings(debug); // Solution is cached timed result
            timeTaken = _timeTaken;
            return result;
        }

        public bool ValidSolution()
        {
            try{
                return ConfirmedAnswer.Equals(Solution);
            }catch(NotImplementedException){
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
