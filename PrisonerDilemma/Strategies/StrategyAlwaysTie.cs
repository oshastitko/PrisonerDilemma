using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonerDilemma.Strategies
{
    public class StrategyAlwaysTie : StrategyBase
    {
        public override Action Init()
        {
            return Action.Tie;
        }
        public override Action Next(Action previousActionOfAnotherPrisoner)
        {
            return Action.Tie;
        }
    }
}
