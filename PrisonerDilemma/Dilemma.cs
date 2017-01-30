using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonerDilemma
{
    public class Dilemma
    {
        private Prisoner prisoner1;
        private Prisoner prisoner2;

        public Dilemma(Prisoner prisoner1, Prisoner prisoner2)
        {
            if (prisoner1 == null)
                throw new ArgumentNullException("prisoner1");

            if (prisoner2 == null)
                throw new ArgumentNullException("prisoner2");


            this.prisoner1 = prisoner1;
            this.prisoner2 = prisoner2;
        }

        public IterationInfo Iteration()
        {
            Action? previousAction1 = prisoner1.LastAction;
            Action? previousAction2 = prisoner2.LastAction;

            prisoner1.Do(previousAction2);
            prisoner2.Do(previousAction1);

            Utils.AddYears(prisoner1, prisoner2);

            return new IterationInfo(prisoner1.LastAction.Value, prisoner2.LastAction.Value, prisoner1.TotalYears, prisoner2.TotalYears);
        }

    }
}
