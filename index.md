## What is Approval Testing

Approval Testing are an open source set of libraries that are  used when verifying complex objects that require human review and approval before they can become an expected result. 
When it would take four of five `Assert` statements to validate a single object, Approval testing can verify an entire object with one `Verify` statement.

For example:

Wwe'll take this test in the arrange phase. We're creating an instance of the thing we want to test, in this case a SolidColorBmpGenerator. In the act phase, we call CreateBmpFile, tell it to create a solid bitmap with the color red, and to output the bitmap file in the temp directory. In the assert phase, we need to read in this file and check that it's red. So, for example, we'd have to read in the bitmap file. And then for every pixel in the bitmap, we'd have to decode the pixel to get the red, green, blue values and then compare the pixel to the RGB values for red. If any of the pixel values don't match, then we'd have to fail the test.

```C#
//Arrange Phase
var sut = new SolidColorBmpGenerator():

//Act Phase
sut.CreateBmpFile(Colors.Red, @"C:\temp\retest.bmp);


// Assert Phase
// 1. Read C:\temp\redtest.bmp
// 2. For every pixel in the bitmap
// 2a. Decode pixel to get RGB values
// 2b. Compare pixel to RGB values for red
// 2c. If pixel value not red then fail the test
```
So you can see we'd have a lot of code in this assert phase. If we're using approval tests, we could simplify this and instead open the bitmap image and look at the image ourselves. If the image looks correct, approve it. This is an example of using human intelligence to determine whether or not the test should pass. And if we approve the image, the approved version will now be used for all future test runs. So we don't have to keep opening up the image for every test run. It will run automatically in the future. 
```C#
// Arrange Phase
var sut = new SolidColorBmpGenerator();
// Act Phase
sut.CreateBmpFile(Colors.Red, @"C:\temp\redtest.bmp");
// Assert Phase (simplified)
// 1. Open C:\temp\redtest.bmp and look at image
// 2. If image is correct, "approve" it
// 3. "Approved" image will be used for all future test runs
```
[CustomObjects Example](https://github.com/yelenagou/ApprovalTesting/tree/main/CustomObjects)
