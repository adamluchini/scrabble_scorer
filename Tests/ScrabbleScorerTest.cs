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

    [Fact]
    public void WordScore_5LetterWordUsing22PointLetters_7()
    {
      string testWord = "edges";
      Assert.Equal(7, ScrabbleScorer.WordScore(testWord));
    }

  }
}
