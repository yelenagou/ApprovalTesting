### Add Approval Tests for Complex Objects
* clone [ApprovalTesting repo](https://github.com/yelenagou/ApprovalTesting.git) to get an initial state of the project

In this project we have a class called a GameEngine

When we create an instance of this GameEngine, we pass in the word that we want to guess. 
Word we want to guess is stored in this private readonly field.

`GuessedLetters` property - every time the player makes a guess, we add a letter to this list. 
    * This property represents the number of guesses remaining, and this defaults to 10. 

`RevealedWord` property -  lists all of the characters that the player has currently guessed correctly. 
    * For any letters of the word that haven't been guessed correctly yet, we're going to output a hyphen.

`Guess` method - So every time the player makes a guess, they pass in a character representing the letter. And if the guess is incorrect, which means that the letter doesn't exist in the word to guess, we would use the GuessesRemaining by one. 

### We've also got a test project in this solution

`Hangman.Tests` solution
* ApprovalTests library has been added to the project
* There is an empty XUnit test class called GameEngineShould
  * One Test Method `UpdateGameState`
* Create an instance of a system under test:
  * `var sut = new GameEngine("Acceptance");`
* Use `Guess` method to guess if a word is correct
```C#
            sut.Guess('x');
            sut.Guess('p');
            sut.Guess('e');
  ```      
* Now we want to assert on the state of the GameEngine object, specifically the revealed word with any correctly guessed letters, the number of guesses remaining, and the list of guessed letters so far. We could do this with multiple xUnit.net asserts.

or we could verify the entire state of the object in a single approval tests verification. So as we did in the previous module, 
we'll call the static Verify method on the Approvals class, and we'll start off by passing in the GameEngine instance.
`Approvals.Verify(sut);`

* When we run the test for the first time it will fail because we need to add `[UseReporter(typeof(DiffReporter))]` before the test method to invoke the diff reporter
* Second time we run, the test should fail because approved file does not match the recieved file, as it should
* By default the `GameEngine` runs a .toString() method on everything we pass it so an entire object is being outputted 
* We can override the .toString() method in the GameEngine to fix that issue
  
```c#
public override string ToString()
		{
            var sb = new StringBuilder();
            sb.AppendFormat("Guessed letters: {0}", new string(GuessedLetters.ToArray()));
            sb.AppendLine();

            sb.AppendFormat("Guessed remaining: {0}", GuessesRemaining);
            sb.AppendLine();

            sb.Append(RevealedWord);
			return sb.ToString();
		}

```

* So now when we call the `Approvals.Verify(sut);` we will call the overridden `.ToString()` method
* When we run again a compare app opens with approved and recieved files
* Test fails because they do not match, but notice that in the recieved file we have a result of an overriden `.toString()` method

So if the result in the recieved file looks good, we can go and approve it by renaming the `*.received.txt` file to approved.
Next time we run the test, test passes because both file matches. 





