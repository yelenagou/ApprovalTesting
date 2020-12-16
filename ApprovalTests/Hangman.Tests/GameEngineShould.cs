using ApprovalTests;
using ApprovalTests.Reporters;
using Hangman;
using Xunit;

namespace Tests
{
    public class GameEngineShould
    {
        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void UpdateGameState()
        {
            //Arrange
            //Create an instsance of a system under tests

            var sut = new GameEngine("Acceptance");

            // We need to make a number of guesses by using GameEgine guess method

            sut.Guess('x');
            sut.Guess('p');
            sut.Guess('e');
            sut.Guess('c');

            //Now we want to assert on the state of the GameEngine object, specifically the revealed word with any correctly guessed letters, 
            //the number of guesses remaining, and the list of guessed letters so far. We could do this with multiple xUnit.net asserts, 


            //or we could verify the entire state of the object in a single approval tests verification. So as we did in the previous module, 
            //we'll call the static Verify method on the Approvals class, and we'll start off by passing in the GameEngine instance.
            //Let's build this and head down to Test Explorer, and we'll go and try and run this test for the first time. 

            Approvals.Verify(sut);

        }
    }
}
