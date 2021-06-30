using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Signlanguage.Models;
using Signlanguage.TextSummerize;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Html.Parser;

namespace Signlanguage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var summarizedDocument = Summarizer.Summarize(
            //    new FileContentProvider("TextualData\\AutomaticSummarization.txt"),
            //    new SummarizerArguments()
            //    {
            //        Language = "en",
            //        MaxSummarySentences = 5,
            //        ContentParser = () => new Content()
            //    });
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult TextSummarization()
        {
            return View();
        }
        public async Task<string> ConvertValue(string value)
        {
            var config = Configuration.Default.WithDefaultLoader();// Create a new browsing context
            var context = BrowsingContext.New(config);// This is where the HTTP request happens, returns <IDocument> that // we can query later
            var document = await context.OpenAsync("http://ec2-54-203-215-115.us-west-2.compute.amazonaws.com/psl-engtosign/psl/getpsl.php?sentence="+value);
            var advertrows = document.QuerySelectorAll("body");

            return advertrows.First().InnerHtml;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
