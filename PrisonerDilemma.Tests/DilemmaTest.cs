using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrisonerDilemma.Tests
{
    [TestClass]
    public class DilemmaTest
    {
        Prisoner prisoner1, prisoner2;
        Dilemma dilemma;


        [TestMethod]
        public void StrategyAlwaysSquealTest()
        {
            prisoner1 = new Prisoner("Prisoner A", new PrisonerDilemma.Strategies.StrategyAlwaysSqueal());
            prisoner2 = new Prisoner("Prisoner B", new PrisonerDilemma.Strategies.StrategyAlwaysSqueal());
            dilemma = new Dilemma(prisoner1, prisoner2);

            dilemma.Iteration();
            Assert.AreEqual(2, prisoner1.TotalYears);
            Assert.AreEqual(2, prisoner2.TotalYears);

            dilemma.Iteration();
            Assert.AreEqual(4, prisoner1.TotalYears);
            Assert.AreEqual(4, prisoner2.TotalYears);

            dilemma.Iteration();
            Assert.AreEqual(6, prisoner1.TotalYears);
            Assert.AreEqual(6, prisoner2.TotalYears);

            dilemma.Iteration();
            Assert.AreEqual(8, prisoner1.TotalYears);
            Assert.AreEqual(8, prisoner2.TotalYears);
        }

        [TestMethod]
        public void StrategyAlwaysTieTest()
        {
            prisoner1 = new Prisoner("Prisoner A", new PrisonerDilemma.Strategies.StrategyAlwaysTie());
            prisoner2 = new Prisoner("Prisoner B", new PrisonerDilemma.Strategies.StrategyAlwaysTie());
            dilemma = new Dilemma(prisoner1, prisoner2);

            dilemma.Iteration();
            Assert.AreEqual(1, prisoner1.TotalYears);
            Assert.AreEqual(1, prisoner2.TotalYears);

            dilemma.Iteration();
            Assert.AreEqual(2, prisoner1.TotalYears);
            Assert.AreEqual(2, prisoner2.TotalYears);

            dilemma.Iteration();
            Assert.AreEqual(3, prisoner1.TotalYears);
            Assert.AreEqual(3, prisoner2.TotalYears);

            dilemma.Iteration();
            Assert.AreEqual(4, prisoner1.TotalYears);
            Assert.AreEqual(4, prisoner2.TotalYears);
        }


        [TestMethod]
        public void StrategyFirstTieBeforeBetrayedSecondAlwaysSquealTest()
        {
            prisoner1 = new Prisoner("Prisoner A", new PrisonerDilemma.Strategies.StrategyTieBeforeAnotherSqueal());
            prisoner2 = new Prisoner("Prisoner B", new PrisonerDilemma.Strategies.StrategyAlwaysSqueal());
            dilemma = new Dilemma(prisoner1, prisoner2);

            dilemma.Iteration();
            Assert.AreEqual(3, prisoner1.TotalYears);
            Assert.AreEqual(0, prisoner2.TotalYears);

            dilemma.Iteration();
            Assert.AreEqual(5, prisoner1.TotalYears);
            Assert.AreEqual(2, prisoner2.TotalYears);

            dilemma.Iteration();
            Assert.AreEqual(7, prisoner1.TotalYears);
            Assert.AreEqual(4, prisoner2.TotalYears);

            dilemma.Iteration();
            Assert.AreEqual(9, prisoner1.TotalYears);
            Assert.AreEqual(6, prisoner2.TotalYears);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatePrisonerTest_NullStrategyFirstPrisoner_Fail()
        {
            prisoner1 = new Prisoner("Prisoner A", null);
            prisoner2 = new Prisoner("Prisoner B", new PrisonerDilemma.Strategies.StrategyAlwaysSqueal());
            dilemma = new Dilemma(prisoner1, prisoner2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatePrisonerTest_NullStrategySecondPrisoner_Fail()
        {
            prisoner1 = new Prisoner("Prisoner A", new PrisonerDilemma.Strategies.StrategyTieBeforeAnotherSqueal());
            prisoner2 = new Prisoner("Prisoner B", null);
            dilemma = new Dilemma(prisoner1, prisoner2);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatePrisonerTest_NullFirstPrisoner_Fail()
        {
            prisoner2 = new Prisoner("Prisoner B", new PrisonerDilemma.Strategies.StrategyAlwaysSqueal());
            dilemma = new Dilemma(null, prisoner2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatePrisonerTest_NullSecondPrisoner_Fail()
        {
            prisoner1 = new Prisoner("Prisoner A", new PrisonerDilemma.Strategies.StrategyTieBeforeAnotherSqueal());
            dilemma = new Dilemma(prisoner1, null);
        }
    }
}
