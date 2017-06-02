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
        RepeatCounter counter = new RepeatCounter();
        int count = counter.CountRepeats(Request.Form["sentence"], Request.Form["word"]);

        return View["results.cshtml", count];
      };
    }
  }
}
