using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonerDilemma.Strategies
{
    public class StrategyAlwaysSqueal : StrategyBase
    {
        public override Action Init()
        {
            return Action.Informer;
        }
        public override Action Next(Action previousActionOfAnotherPrisoner)
        {
            return Action.Informer;
        }
    }
}
