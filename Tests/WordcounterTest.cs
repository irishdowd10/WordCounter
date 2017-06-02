using Xunit;
using WordCounter.Objects;
using System;
using System.Collections.Generic;

namespace WordCcounter
{
    public class WordTest
    {
      [Fact]
      public void Test_CountRepeats_SentenceEqualsWord()
      {
        string sentence = "i";
        string word = "i";

        RepeatCounter counter = new RepeatCounter();

        int count = counter.CountRepeats(sentence, word);

        Assert.Equal(count, 1);
      }

      [Fact]
      public void Test_CountRepeats_IgnoresCase()
      {
        string sentence = "I";
        string word = "i";

        RepeatCounter counter = new RepeatCounter();

        int count = counter.CountRepeats(sentence, word);

        Assert.Equal(count, 1);
      }
    }
  }
