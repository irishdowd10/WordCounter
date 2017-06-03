using Nancy;
using System;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter.Modules
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/results"] = _ => {
        RepeatCounter counter = new RepeatCounter(Request.Form["sentence"], Request.Form["word"]);
        // int count = counter.CountRepeats();

        return View["results.cshtml", counter];
      };
    }
  }
}
