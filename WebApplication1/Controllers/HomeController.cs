using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Controller] // атрибут (необязателен, если суффикс controller или наследуем от класса с суффиксом Controller) 
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ActionName("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ActionName("Privacy")]
        public IActionResult PrivacyAttributeExample()
        {
            return View();
        }

        [NonAction]
        public string MyActionFromGuide() => "Hello METANIT.COM";

        // пример из гайда
        public async Task GuideRequest()
        {
            Response.ContentType = "text/html;charset=utf-8";
            await Response.WriteAsync("<h2>Hello METANIT.COM</h2>");
        }

        // пример из гайда Response
        public async Task GuideResponseRequest()
        {
            Response.ContentType = "text/html;charset=utf-8";
            System.Text.StringBuilder tableBuilder = new("<h2>Request headers</h2><table>");
            foreach (var header in Request.Headers)
            {
                tableBuilder.Append($"<tr><td>{header.Key}</td><td>{header.Value}</td></tr>");
            }
            tableBuilder.Append("</table>");
            await Response.WriteAsync(tableBuilder.ToString());
        }

        // Гайд, передача параметра
        public string GuideParameter(string name, int age = 33)
        {
            return $"Your name: {name}, Age: {age}";
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}