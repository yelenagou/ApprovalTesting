# ApprovalTesting

### Maintaining approval tests

Often times, once test cases get developed, approval files get out of date.

For example:

In this project you have a test method name ` public void Build()` in the HtmlReportBuilderShould file. 

Let's say you renamed the test method to `public void BuildAnnualReport()`;

When you run the tests, you will have two approval files. 

In order to cleanup unused approval files, you can add a separate test class with a test method that contains `ApprovalMaintenance.VerifyNoAbandonedFiles()` method. 
This method only needs to run once. 
