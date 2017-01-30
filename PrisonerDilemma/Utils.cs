using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonerDilemma
{
    internal static class Utils
    {
        public static void AddYears(Prisoner prisoner1, Prisoner prisoner2)
        {
            if (prisoner1.LastAction.Value == Action.Informer)
            {
                if (prisoner2.LastAction.Value == Action.Informer)
                {
                    prisoner1.AddYears(ConvictionYears.InformerToInformer);
                    prisoner2.AddYears(ConvictionYears.InformerToInformer);
                }

                if (prisoner2.LastAction.Value == Action.Tie)
                {
                    prisoner1.AddYears(ConvictionYears.InformerToTie);
                    prisoner2.AddYears(ConvictionYears.TieToInformer);
                }

            }

            if (prisoner1.LastAction.Value == Action.Tie)
            {
                if (prisoner2.LastAction.Value == Action.Informer)
                {
                    prisoner1.AddYears(ConvictionYears.TieToInformer);
                    prisoner2.AddYears(ConvictionYears.InformerToTie);
                }

                if (prisoner2.LastAction.Value == Action.Tie)
                {
                    prisoner1.AddYears(ConvictionYears.TieToTie);
                    prisoner2.AddYears(ConvictionYears.TieToTie);
                }

            }

        }
    }
}
