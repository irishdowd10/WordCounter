using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
    public class RepeatCounter
    {
      private string _sentence;
      private string _word;
      private int _count;

      public RepeatCounter(string sentence, string word)
      {
        _sentence = sentence.ToLower();
        _word = word.ToLower();
        _count = 0;
      }

      public void SetSentence(string sentence)
      {
        _sentence = sentence;
      }

      public void SetWord(string word)
      {
        _word = word;
      }

      public string GetWord()
      {
        return _word;
      }

      public string GetSentence()
      {
        return _sentence;
      }

      public int CountRepeats()
      {
        _count = 0;

        if(_sentence == _word)
          return 1;

        string[] wordArray = _sentence.Split(' ');

        for(int i = 0; i < wordArray.Length; i++)
        {
          if(wordArray[i] == _word)
            _count++;
        }

        return _count;
      }
    }
}
