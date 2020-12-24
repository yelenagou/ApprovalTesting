using ApprovalTests.Reporters;
using AnnualReportBuilder;
using Xunit;
using ApprovalTests;

namespace Tests
{
    
    public class BitmapReportBuilderShould
    {
        [Fact]
        [UseReporter(typeof(WinMergeReporter), typeof(ClipboardReporter))]
        public void RenderPNGImage()
        {
            var model = new ReportModel
            {
                Title = "Annual Report",
                ReportLines =
                {
                    "Line 1",
                    "Line 2",
                    "Line 3",
                    "Line 4",
                    "Line 5"
                }
            };

            var sut = new BitmapReportBuilder(model);
            byte[] bitmap = sut.Render();
            Approvals.VerifyBinaryFile(bitmap, ".png");

        }

    }
}
