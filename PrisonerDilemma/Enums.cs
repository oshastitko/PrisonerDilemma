using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonerDilemma
{
    public enum Action
    {
        Tie = 0,
        Informer = 1
    }

    public enum ConvictionYears
    {
        InformerToTie = 0,
        TieToTie = 1,
        InformerToInformer = 2,
        TieToInformer = 3
    }
}
