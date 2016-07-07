using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Objects
{
  public class ScrabbleScorer
  {
    public static int WordScore(string input)
    {
      Dictionary<char, int> testDictionary = new Dictionary<char, int> {};

      testDictionary.Add('A', 1);
      testDictionary.Add('E', 1);
      testDictionary.Add('I', 1);
      testDictionary.Add('O', 1);
      testDictionary.Add('U', 1);
      testDictionary.Add('L', 1);
      testDictionary.Add('N', 1);
      testDictionary.Add('R', 1);
      testDictionary.Add('S', 1);
      testDictionary.Add('T', 1);

      int scoreTotal = 0;

      string upperCaseInput = input.ToUpper();
      char[] inputArray = upperCaseInput.ToCharArray();
      for (int i = 0; i < inputArray.Length; i++) {
        foreach (KeyValuePair<char, int> test in testDictionary) {
          if (inputArray[i] == test.Key)
          {
            scoreTotal += test.Value;
          }
        }
      }
      return scoreTotal;
    }
  }
}
