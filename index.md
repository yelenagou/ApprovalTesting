## What is Approval Testing

Approval Testing is used when verifying complex objects that require human review and approval before they can become an expected result. 
When it would take four of five `Assert` statements to validate a single object, Approval testing can verify an entire object with one `Verify` statement.

For example:
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

You can use the [editor on GitHub](https://github.com/yelenagou/ApprovalTesting/edit/gh-pages/index.md) to maintain and preview the content for your website in Markdown files.

Whenever you commit to this repository, GitHub Pages will run [Jekyll](https://jekyllrb.com/) to rebuild the pages in your site, from the content in your Markdown files.

### Markdown

Markdown is a lightweight and easy-to-use syntax for styling your writing. It includes conventions for

```markdown
Syntax highlighted code block

# Header 1
## Header 2
### Header 3

- Bulleted
- List

1. Numbered
2. List

**Bold** and _Italic_ and `Code` text

[Link](url) and ![Image](src)
```

For more details see [GitHub Flavored Markdown](https://guides.github.com/features/mastering-markdown/).

### Jekyll Themes

Your Pages site will use the layout and styles from the Jekyll theme you have selected in your [repository settings](https://github.com/yelenagou/ApprovalTesting/settings). The name of this theme is saved in the Jekyll `_config.yml` configuration file.

### Support or Contact

Having trouble with Pages? Check out our [documentation](https://docs.github.com/categories/github-pages-basics/) or [contact support](https://github.com/contact) and we’ll help you sort it out.
