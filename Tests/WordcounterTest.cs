using Xunit;
using WordCounter.Objects;
using System;
using System.Collections.Generic;

namespace WordCcounter
{
    public class WordTest
    {
      [Fact]
      public void CountRepeatsii1()
      {
        string sentence = "i";
        string word = "i";

        RepeatCounter counter = new RepeatCounter();

        int count = counter.CountRepeats(sentence, word);

        Assert.Equal(count, 1);
      }
    }
  }
