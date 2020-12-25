# ApprovalTesting

### Approval Tests with Selenium Web Driver

We can use Selenium to render the web page and capture the screenshot to build a recieved 

Run the webapp without debugging and note the URL. 

Add a test method to the test class:
```C#
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
```

In the test method above, we take a screenshot with selenium web driver and then compare the screenshot as byte array. 
