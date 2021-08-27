using EEDemo.Helpers.Scenarios;



namespace EETestProject
{
    
    public class RunTest1 : Scenario1
        {
            
            private static void S1()
            {
                Scenario1 scenario1 = new Scenario1();
                scenario1.RunScenario1();
            }
        }
    public class RunTest2 : Scenario2
        {
            
            private static void S2()
            {
                Scenario2 scenario2 = new Scenario2();
                scenario2.RunScenario2();
            }
        }
    public class RunTest3 : Scenario3
    {
        
        private static void S3()
        {
            Scenario3 scenario3 = new Scenario3();
            scenario3.RunScenario3();
        }
    }

}
