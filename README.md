# ApprovalTesting

### Using Framework Reporter

* When running tests on the agent, we do not want to open a compare program
* We can use default framework reporter to view the images
* Change the report to either XUnit2Reporter or FrameworkAssertReport
* When report is ran, default framework reporter will be opened. 
  
Make change to the Line 1 string 
  
  ```C#
  
        public class HtmlReportBuilderShould
    {
        [Fact]
        [UseReporter(typeof(XUnit2Reporter))]
        public void Build()
        {
            var model = new ReportModel
            {
                Title = "Annual Report",
                ReportLines =
                            {
                                "Line 1xyz",
                                "Line 2",
                                "Line 3",
                                "Line 4",
                                "Line 5"
                            }
            };

            var sut = new HtmlReportBuilder(model);

            string html = sut.Build();

            Approvals.VerifyHtml(html);
        }
    }

```
* When test fail an Xunit reporter will be open
This type of reporter is not useful for images.

You can set a reporter on method level, test case level, or an assembly level
[assembly: FrontLoadedReporter(typeof(DefaultFrontLoaderReporter))]
