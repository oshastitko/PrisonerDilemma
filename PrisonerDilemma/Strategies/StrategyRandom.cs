using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PrisonerDilemma.Strategies
{
    public class StrategyRandom : StrategyBase
    {
        public override Action Init()
        {
            var r = Rnd();
            return r;
        }
        public override Action Next(Action previousActionOfAnotherPrisoner)
        {
            var r = Rnd();
            return r;
        }

        Random rnd = new Random(unchecked((int)(DateTime.Now.Ticks)));


        Action Rnd()
        {
            byte first = Guid.NewGuid().ToByteArray()[0];

            return (first < 128) ? Action.Tie : Action.Informer;
            //return (Action)rnd.Next(0, 2);
        }
    }
}
