using ApprovalTests;
using ApprovalTests.Reporters;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace WebApplication1.Tests
{
    public class HomePageShould
    {
        [Fact]
        [UseReporter(typeof(DiffReporter), typeof(ClipboardReporter))]
        public void RenderWithoutError()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Size = new System.Drawing.Size(1000, 800);

                const string homeUrl = "http://localhost:6858/";

                driver.Navigate().GoToUrl(homeUrl);

                ITakesScreenshot screenshotDriver = (ITakesScreenshot)driver;
                Screenshot screen = screenshotDriver.GetScreenshot();
                Approvals.VerifyBinaryFile(screen.AsByteArray, ".png");

            }
        }
    }
}
