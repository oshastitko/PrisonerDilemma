using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonerDilemma.Strategies
{
    public class StrategyViceVersa : StrategyBase
    {
        public override Action Init()
        {
            return Action.Tie;
        }
        public override Action Next(Action previousActionOfAnotherPrisoner)
        {
            return (previousActionOfAnotherPrisoner == Action.Informer) ? Action.Tie : Action.Informer;
        }
    }
}
