using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using courseSearch.Models;
using courseSearch.data;
using Microsoft.AspNetCore.Http;

namespace courseSearch.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

     private readonly MyDbContext _context;

    public HomeController(ILogger<HomeController> logger, MyDbContext context)
    {
        _logger = logger;
        _context = context;
         
    }


    public IActionResult Index()
    {

      
      var subjects = GetSubject();
    
        return View();
    }

   


    [Route("GetSubject")]
    [HttpGet]
    public IActionResult GetSubject()
    {
        var subjectList = _context.Subjects_Required.ToList();

        ViewBag.subjectOptions = subjectList;

        return Json(subjectList);
    }


    [Route("CalculateSumLevel")]
    [HttpPost]
    public IActionResult CalculateSumLevel(IFormCollection form)
    {
        // Get the values of the level elements from the form collection
       int sumLevel = 0;
        foreach (var value in form["level"])
        {
            int selectedValue;
            if (int.TryParse(value, out selectedValue))
            {
            sumLevel += selectedValue;
            }
        }
        
        return Json(sumLevel); 
    }

    [Route("CalculatePercLevel")]
     [HttpPost]
    public IActionResult CalculatePercLevel(IFormCollection form)
    {
        
        // Get the values of the percent elements from the form collection
        int sumPerc = 0;
        foreach (var value in form["percent"])
        {
            int selectedValue;
            if (int.TryParse(value, out selectedValue))
            {
            sumPerc += selectedValue;
            }
        }

        return Json(sumPerc); 
    }

    

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
