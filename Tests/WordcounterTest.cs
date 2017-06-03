using Xunit;
using WordCounter.Objects;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
    public class WordTest
    {
      [Fact]
      public void Test_CountRepeats_SentenceEqualsWord()
      {
        string sentence = "i";
        string word = "i";

        RepeatCounter counter = new RepeatCounter(sentence, word);

        int count = counter.CountRepeats();

        Assert.Equal(count, 1);
      }

      [Fact]
      public void Test_CountRepeats_IgnoresCase()
      {
        string sentence = "I";
        string word = "i";

        RepeatCounter counter = new RepeatCounter(sentence, word);

        int count = counter.CountRepeats();

        Assert.Equal(count, 1);
      }

      [Fact]
      public void Test_CountRepeats_OnlyMatchWords()
      {
        string sentence = "bird";
        string word = "i";

        RepeatCounter counter = new RepeatCounter(sentence, word);

        int count = counter.CountRepeats();

        Assert.Equal(count, 0);
      }

      [Fact]
      public void Test_CountRepeats_AccountForSpaces()
      {
        string sentence = "i love";
        string word = "I";

        RepeatCounter counter = new RepeatCounter(sentence, word);

        int count = counter.CountRepeats();

        Assert.Equal(count, 1);
      }

      [Fact]
      public void Test_CountRepeats_AccountForMultiple()
      {
        string sentence = "friday is always good friday";
        string word = "friday";

        RepeatCounter counter = new RepeatCounter(sentence, word);

        int count = counter.CountRepeats();

        Assert.Equal(count, 2);
      }
    }
  }
