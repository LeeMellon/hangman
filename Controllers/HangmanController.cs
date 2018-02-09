using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Hangmen.Models;

namespace Hangmen.Controllers
{

public class HangmenController : Controller
  {

      [HttpGet("/")]
      public ActionResult Index()
      {
        Hangman Buster = new Hangman();
        string theWord = Buster.ChooseWord();
        Buster.SetAnswer(theWord);
        System.Console.WriteLine(theWord);
        return View();
      }


      [HttpPost("/")]
      public ActionResult TakeInGuess(Hangman Buster)
      {
        string MyGuess = Request.Form["myGuess"];
        System.Console.WriteLine(Buster.GetAnswer);
        return View("Index");
      }
  }
}
