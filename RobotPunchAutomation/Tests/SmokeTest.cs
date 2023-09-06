using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RobotPunchAutomation.Tests
{
    [TestFixture]
    public class SmokeTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Close();
        }

        [Test]
        public void BasicSmokeTest()
        {
            _driver.Navigate().GoToUrl("https://youtube.com");
        }
        
        
    }
}