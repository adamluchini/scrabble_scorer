using Nancy;
using ScrabbleScorer.Objects;
using System.Collections.Generic;

namespace ScrabbleScorer.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]= _ => {
        return View["index.cshtml"];
      };
      Post["/"]= _ =>
      {
        return View["index.cshtml", ScrabbleScorer.WordScore(Request.Form["input"])];
      };
    }
  }
}
