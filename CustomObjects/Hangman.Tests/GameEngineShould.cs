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
            var sut = new GameEngine("Pluralsight");

            sut.Guess('x');
            sut.Guess('p');
            sut.Guess('l');

            Approvals.Verify(sut);
        }
    }
}
