using Microsoft.AspNetCore.Mvc;
using HangmanGame.Models;

namespace HangmanGame.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Title() { return View(); }

  }
}