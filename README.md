# ApprovalTesting

### Reporting Image differences

* For more information go to: https://yelenagou.github.io/ApprovalTesting/

* The sample program creates an image layout of a report
* We need to ensure that the image is approved
  * Add a test method to the `BitmapReportBuilderShould.cs` file:
  
  ```C#
  
        [Fact]
        [UseReporter(typeof(FileLauncherReporter), typeof(ClipboardReporter))]
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

```
* We are using File Launcher Reporter for approval 
* Run the test 
  * First time the test should fail
  * Default image program opens
  * Since we are using ClipboardReporter to manage our approvals, open cmd and paste the command that has been copied to your clipboard during runtime
    * You will have an approved file
    * If you run the test again it should pass
* You can change which report you are going to use
