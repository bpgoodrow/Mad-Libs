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
    [Route("/forms2")]
    public ActionResult Forms2() { return View(); }
    
    [Route("/madlibs2")]
    public ActionResult Madlibs2(string adjective, string foods, string verb, string saying, string noun, string foods2, string color, string ride, string animal, string person)
    {
      MadlibsVariable2 myMadlibsVariable2 = new MadlibsVariable2();
      myMadlibsVariable2.Adjective = adjective;
      myMadlibsVariable2.Foods = foods;
      myMadlibsVariable2.Verb = verb;
      myMadlibsVariable2.Saying = saying;
      myMadlibsVariable2.Noun = noun;
      myMadlibsVariable2.Foods2 = foods2;
      myMadlibsVariable2.Color = color;
      myMadlibsVariable2.Ride = ride;
      myMadlibsVariable2.Animal = animal;
      myMadlibsVariable2.Person = person;
      return View(myMadlibsVariable2);
    }

  }
}