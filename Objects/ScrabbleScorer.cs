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

      newDictionary.Add('B', 3);
      newDictionary.Add('C', 3);
      newDictionary.Add('M', 3);
      newDictionary.Add('P', 3);

      newDictionary.Add('F', 4);
      newDictionary.Add('H', 4);
      newDictionary.Add('V', 4);
      newDictionary.Add('W', 4);
      newDictionary.Add('Y', 4);

      newDictionary.Add('K', 5);

      newDictionary.Add('J', 8);
      newDictionary.Add('X', 8);

      newDictionary.Add('Q', 10);
      newDictionary.Add('Z', 10);

      int scoreTotal = 0;

      string upperCaseInput = input.ToUpper();
      char[] inputArray = upperCaseInput.ToCharArray(); //calling ToCharArray method to put upperCaseInput into inputArray
      for (int i = 0; i < inputArray.Length; i++){
        foreach (KeyValuePair<char, int> test in newDictionary){
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
