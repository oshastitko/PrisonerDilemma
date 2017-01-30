using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonerDilemma.Strategies
{
    public class StrategyTieBeforeAnotherSqueal : StrategyBase
    {
        bool haveBeenBetrayed = false;
        public override Action Init()
        {
            return Action.Tie;
        }
        public override Action Next(Action previousActionOfAnotherPrisoner)
        {
            if (previousActionOfAnotherPrisoner == Action.Informer)
                haveBeenBetrayed = true;

            return (haveBeenBetrayed) ? Action.Informer : Action.Tie;
        }
    }
}
