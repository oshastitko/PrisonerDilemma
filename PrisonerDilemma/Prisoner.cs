using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonerDilemma
{
    public class Prisoner 
    {
        public string PrisonerName { get; private set; }
        public StrategyBase Strategy { get; private set; }
        public Action? LastAction { get; private set; }
        public int TotalYears { get; private set; }

        public Prisoner(string name, StrategyBase strategy)
        {
            if (strategy == null)
                throw new ArgumentNullException("strategy");

            PrisonerName = name;
            Strategy = strategy;
        }

        public void Do(Action? previousActionOfAnotherPrisoner)
        {
            if (previousActionOfAnotherPrisoner == null)
                LastAction = Strategy.Init();
            else
                LastAction = Strategy.Next(previousActionOfAnotherPrisoner.Value);
        }

        public void AddYears(ConvictionYears years)
        {
            TotalYears += (int)years;
        }
    }
}
