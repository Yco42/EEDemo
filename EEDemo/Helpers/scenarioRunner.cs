using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace EEDemo.Helpers.Scenarios
{
    
    
    public class Scenario1
    {
        private string _fnameElement = "input#firstname";
        private string _lnameElement = "input#lastname";
        private string _price = "input#totalprice";
        private string _deposit = "select#depositpaid";
        private string _checkin = "input#checkin";
        private string _checkout = "input#checkout";
        private string _save = "input[value=' Save ']";

       
        public void RunScenario1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://hotel-test.equalexperts.io/";
            driver.FindElement(By.CssSelector(_fnameElement)).SendKeys("!@5_ X");
            driver.FindElement(By.CssSelector(_lnameElement)).SendKeys("ข ไข่");
            driver.FindElement(By.CssSelector(_price)).SendKeys("10");
            driver.FindElement(By.CssSelector(_deposit)).SendKeys("t");
            driver.FindElement(By.CssSelector(_checkin)).SendKeys("2019-09-02");
            driver.FindElement(By.CssSelector(_checkout)).SendKeys("2022-12-14");
            driver.FindElement(By.CssSelector(_save)).Click();
            driver.Dispose();
        }
 
    }
    public class Scenario2
    {
        private string _fnameElement = "input#firstname";
        private string _lnameElement = "input#lastname";
        private string _deposit = "select#depositpaid";
        private string _checkin = "input#checkin";
        private string _checkout = "input#checkout";
        private string _save = "input[value=' Save ']";

        
        public void RunScenario2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://hotel-test.equalexperts.io/";
            driver.FindElement(By.CssSelector(_fnameElement)).SendKeys("test");
            driver.FindElement(By.CssSelector(_lnameElement)).SendKeys("two");
            driver.FindElement(By.CssSelector(_deposit)).SendKeys("f");
            driver.FindElement(By.CssSelector(_checkin)).SendKeys("20/08/2021");
            driver.FindElement(By.CssSelector(_checkout)).SendKeys("19/08/2021");
            driver.FindElement(By.CssSelector(_save)).Click();
            driver.Dispose();
        }

    }

    public class Scenario3
    {
        private string _fnameElement = "input#firstname";
        private string _lnameElement = "input#lastname";
        private string _price = "input#totalprice";
        private string _deposit = "select#depositpaid";
        private string _checkin = "input#checkin";
        private string _checkout = "input#checkout";
        private string _save = "input[value=' Save ']";

        
        public void RunScenario3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://hotel-test.equalexperts.io/";
            driver.FindElement(By.CssSelector(_fnameElement)).SendKeys("valid");
            driver.FindElement(By.CssSelector(_lnameElement)).SendKeys("test");
            driver.FindElement(By.CssSelector(_price)).SendKeys("10");
            driver.FindElement(By.CssSelector(_deposit)).SendKeys("t");
            driver.FindElement(By.CssSelector(_checkin)).SendKeys("29/08/2022");
            driver.FindElement(By.CssSelector(_checkout)).SendKeys("30/08/2022");
            driver.FindElement(By.CssSelector(_save)).Click();
            driver.Dispose();
        }

    }
}
