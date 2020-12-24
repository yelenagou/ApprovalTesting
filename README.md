# ApprovalTesting

### Scrubbing approved files during execution

* For more information go to: https://yelenagou.github.io/ApprovalTesting/

* Open the approved file.
    - Note there is an arbitrary date that user wants to see. 
* Update the EmployeeReportGenerator.cs file to match the report

```C#
    reportText.AppendLine($"Date Generated: {DateTime.Now:MMMM d, yyyy}");
    reportText.AppendLine();
```

  - Notice that we are using DateTime.Now which would not match the report

- If we run the test, it will fail because dates don't match.

* Use scrubbing feature of approval tests:
There is an overload to an `Approvals.Verify` function that accepts the input string as it's first parameter and a function that checks the input and replaces it. 
```C#
        Approvals.Verify(reportText,
        (input) => Regex.Replace(input, "Date Generated.*", "Date Generated: July 1, 2000"));
```
### Other Verification Methods


