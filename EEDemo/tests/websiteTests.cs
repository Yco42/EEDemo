using NUnit;
using NUnit.Framework;
using EEDemo.Helpers.Scenarios;



namespace EETestProject
{
    [TestFixture]
    public class RunTest1 : Scenario1
        {
        [Test]
        public static void S1()
            {
                Scenario1 scenario1 = new Scenario1();
                scenario1.RunScenario1();
            }
        }
    public class RunTest2 : Scenario2
        {
        [Test]
        public static void S2()
            {
                Scenario2 scenario2 = new Scenario2();
                scenario2.RunScenario2();
            }
        }
    public class RunTest3 : Scenario3
    {
        [Test]
        public static void S3()
        {
            Scenario3 scenario3 = new Scenario3();
            scenario3.RunScenario3();
        }
    }

}
