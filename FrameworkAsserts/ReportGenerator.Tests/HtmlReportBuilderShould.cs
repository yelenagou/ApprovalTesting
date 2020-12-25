using ApprovalTests.Reporters;
using Xunit;
using ApprovalTests;
using ApprovalTests.Reporters.TestFrameworks;
using ApprovalTests.Maintenance;

namespace ReportGenerator.Tests
{
    public class HtmlReportBuilderShould
    {
       
        [Fact]
        [UseReporter(typeof(WinMergeReporter),typeof(FileLauncherReporter), typeof(ClipboardReporter))]
        public void BuildAnnualReport()
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
}
