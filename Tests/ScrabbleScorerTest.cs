using System.Collections.Generic;
using Xunit;

namespace ScrabbleScorer.Objects
{
  public class ScrabbleScorerTest
  {
    [Fact]
    public void WordScore_5LetterWordUsing1PointLetters_5()
    {
      string testWord = "alert";
      Assert.Equal(5, ScrabbleScorer.WordScore(testWord));
    }
  }

}
