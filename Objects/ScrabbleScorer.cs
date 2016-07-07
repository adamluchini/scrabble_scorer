using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Objects
{
  public class ScrabbleScorer
  {
    public static int WordScore(string input)
    {
      Dictionary<char, int> newDictionary = new Dictionary<char, int> {};

      newDictionary.Add('A', 1);
      newDictionary.Add('E', 1);
      newDictionary.Add('I', 1);
      newDictionary.Add('O', 1);
      newDictionary.Add('U', 1);
      newDictionary.Add('L', 1);
      newDictionary.Add('N', 1);
      newDictionary.Add('R', 1);
      newDictionary.Add('S', 1);
      newDictionary.Add('T', 1);

      newDictionary.Add('D', 2);
      newDictionary.Add('G', 2);

      int scoreTotal = 0;

      string upperCaseInput = input.ToUpper();
      char[] inputArray = upperCaseInput.ToCharArray();
      for (int i = 0; i < inputArray.Length; i++) {
        foreach (KeyValuePair<char, int> test in newDictionary) {
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
