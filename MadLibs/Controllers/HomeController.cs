using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index() {return View(); }

    [Route("/forms")]
    public ActionResult Forms() { return View(); }

    [Route("/madlibs")]
    public ActionResult Madlibs(string things, string adjective, string songtitle, string celebrity, string feeling, string verb, string place, string food, string things2, string person)
    {
      MadlibsVariable myMadlibsVariable = new MadlibsVariable();
      myMadlibsVariable.Things = things;
      myMadlibsVariable.Adjective = adjective;
      myMadlibsVariable.Songtitle = songtitle;
      myMadlibsVariable.Celebrity = celebrity;
      myMadlibsVariable.Feeling = feeling;
      myMadlibsVariable.Verb = verb;
      myMadlibsVariable.Place = place;
      myMadlibsVariable.Food = food;
      myMadlibsVariable.Things2 = things2;
      myMadlibsVariable.Person = person;
      return View(myMadlibsVariable);
    }

  }
}