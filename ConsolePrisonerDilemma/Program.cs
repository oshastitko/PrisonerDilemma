using PrisonerDilemma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrisonerDilemma
{
    class Program
    {
        static Prisoner prisoner1, prisoner2;
        static Dilemma dilemma;

        public static void Main(string[] args)
        {

            Console.WriteLine("Strategy 'Both always squeal'");
            prisoner1 = new Prisoner("Prisoner A", new PrisonerDilemma.Strategies.StrategyAlwaysSqueal());
            prisoner2 = new Prisoner("Prisoner B", new PrisonerDilemma.Strategies.StrategyAlwaysSqueal());
            dilemma = new Dilemma(prisoner1, prisoner2);
            StrategyPrint();
            Console.WriteLine("----------------");


            Console.WriteLine("Strategy 'Both always tie'");
            prisoner1 = new Prisoner("Prisoner A", new PrisonerDilemma.Strategies.StrategyAlwaysTie());
            prisoner2 = new Prisoner("Prisoner B", new PrisonerDilemma.Strategies.StrategyAlwaysTie());
            dilemma = new Dilemma(prisoner1, prisoner2);
            StrategyPrint();
            Console.WriteLine("----------------");



            Console.WriteLine("Strategy 'First tie before Second squeal, Second always squeal'");
            prisoner1 = new Prisoner("Prisoner A", new PrisonerDilemma.Strategies.StrategyTieBeforeAnotherSqueal());
            prisoner2 = new Prisoner("Prisoner B", new PrisonerDilemma.Strategies.StrategyAlwaysSqueal());
            dilemma = new Dilemma(prisoner1, prisoner2);
            StrategyPrint();
            Console.WriteLine("----------------");


            Console.WriteLine("Strategy 'First tie before Second squeal, Second is random'");
            prisoner1 = new Prisoner("Prisoner A", new PrisonerDilemma.Strategies.StrategyTieBeforeAnotherSqueal());
            prisoner2 = new Prisoner("Prisoner B", new PrisonerDilemma.Strategies.StrategyRandom());
            dilemma = new Dilemma(prisoner1, prisoner2);
            StrategyPrint();
            Console.WriteLine("----------------");


            Console.WriteLine("Strategy 'Both are random'");
            prisoner1 = new Prisoner("Prisoner A", new PrisonerDilemma.Strategies.StrategyRandom());
            prisoner2 = new Prisoner("Prisoner B", new PrisonerDilemma.Strategies.StrategyRandom());
            dilemma = new Dilemma(prisoner1, prisoner2);
            StrategyPrint();
            Console.WriteLine("----------------");


            Console.ReadLine();
        }

        static void StrategyPrint()
        {
            for (int i = 0; i < 20; i++)
            {
                var info = dilemma.Iteration();
                string prisoner1action = String.Empty;
                if (prisoner1.LastAction.HasValue)
                    prisoner1action = prisoner1.LastAction.Value.ToString();

                string prisoner2action = String.Empty;
                if (prisoner2.LastAction.HasValue)
                    prisoner2action = prisoner2.LastAction.Value.ToString();

                Console.WriteLine($"{prisoner1.PrisonerName}: {info.TotalYearsPrisoner1}, {prisoner1action}; {prisoner2.PrisonerName}: {info.TotalYearsPrisoner2} {prisoner2action}");
            }
        }

    }
}
