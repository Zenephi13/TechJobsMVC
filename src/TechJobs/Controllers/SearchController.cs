using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;
using System.Diagnostics;


namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results
        public IActionResult Results(string searchType, string searchTerm)
        {
            if (searchType == "all")
            {
                ViewBag.jobs = JobData.FindByValue(searchTerm);
            }
            else
            {
             ViewBag.jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            }
            ViewBag.title = "Results";
            ViewBag.columns = ListController.columnChoices;
            return View("Index");
        }
    }
}
