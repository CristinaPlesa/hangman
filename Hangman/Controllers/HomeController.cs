using Microsoft.AspNetCore.Mvc;
using Hangman.Models;

namespace Hangman.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Title() { return View(); }

  }
}