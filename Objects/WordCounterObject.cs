using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
    public class RepeatCounter
    {
      public int CountRepeats(string sentence, string word)
      {
        int count = 0;

        if(sentence == word)
          return 1;

        return count;
      }
    }
}
