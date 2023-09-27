using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers;

public class SurveyController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View();
    }

    // [HttpGet("results/{results}")]
    // public ViewResult Results(List<string> results)
    // {
    //     ViewBag.Name = results[0];
    //     ViewBag.Dojo = results[1];
    //     ViewBag.Language = results[2];
    //     ViewBag.Comment = results[3];

    //     return View();
    // }

    [HttpPost("results")]
    public IActionResult Process(string Name, string Dojo, string Language, string Comment)
    {

        // List<string> results = new();
        // results.Add(Name);
        // results.Add(Dojo);
        // results.Add(Language);
        // results.Add(Comment);


        ViewBag.Name = Name;
        ViewBag.Dojo = Dojo;
        ViewBag.Language = Language;
        ViewBag.Comment = Comment;


        return View("Results");
    }
}