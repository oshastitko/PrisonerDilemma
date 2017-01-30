using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonerDilemma
{
    public class IterationInfo
    {
        public Action ActionPrisoner1 { get; private set; }
        public Action ActionPrisoner2 { get; private set; }
        public int TotalYearsPrisoner1 { get; private set; }
        public int TotalYearsPrisoner2 { get; private set; }

        public IterationInfo(Action actionPrisoner1, Action actionPrisoner2, int totalYearsPrisoner1, int totalYearsPrisoner2)
        {
            ActionPrisoner1 = actionPrisoner1;
            ActionPrisoner2 = actionPrisoner2;
            TotalYearsPrisoner1 = totalYearsPrisoner1;
            TotalYearsPrisoner2 = totalYearsPrisoner2;
        }
    }
}
