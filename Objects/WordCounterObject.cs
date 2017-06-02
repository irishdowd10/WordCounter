using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
    public class RepeatCounter
    {
      public int CountRepeats(string sentence, string word)
      {
        int count = 0;

        sentence = sentence.ToLower();
        word = word.ToLower();

        if(sentence == word)
          return 1;

        string[] wordArray = sentence.Split(' ');

        for(int i = 0; i < wordArray.Length; i++)
        {
          if(wordArray[i] == word)
            count++;
        }

        return count;
      }
    }
}
