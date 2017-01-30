using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonerDilemma
{
    public abstract class StrategyBase
    {
        public string StrategyName { get; set; }
        public abstract Action Init();
        public abstract Action Next(Action previousActionOfAnotherPrisoner);
    }
}
