using System.Collections.Generic;
using Xunit;

namespace ScrabbleScorer.Objects
{
  public class ScrabbleScorerTest
  {
    [Fact]
    public void WordScore_5LetterWordUsing1PointLetters_5()
    {
      string testWord = "ALERT";
      Assert.Equal(5, ScrabbleScorer.WordScore(testWord));
    }

    [Fact]
    public void WordScore_5LetterWordUsing1and2PointLetters_7()
    {
      string testWord = "EDGES";
      Assert.Equal(7, ScrabbleScorer.WordScore(testWord));
    }

    [Fact]
    public void WordScore_5LetterWordUsing1and2and3PointLetters_8()
    {
      string testWord = "CLOUD";
      Assert.Equal(8, ScrabbleScorer.WordScore(testWord));
    }

    [Fact]
    public void WordScore_5LetterWordUsing1and2and3and4PointLetters_13()
    {
      string testWord = "DUMPY";
      Assert.Equal(13, ScrabbleScorer.WordScore(testWord));
    }

  }
}
