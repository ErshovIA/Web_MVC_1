using Microsoft.AspNetCore.Mvc;
//using System.Text.Encodings.Web;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        // https://localhost:7212/HelloWorld
        public string Index()
        {
            return "This is my default action...";
        }
        // 
        // GET: /HelloWorld/Welcome
        // https://localhost:7212/HelloWorld/Welcome
        public string Welcome()
        {
            String responseStr = "<h1 class=\"display-4\">This is the Welcome action method<br>We from HelloWorld controller</h1>";
            return responseStr;
        }

        // View //
        public IActionResult DemoView()
        {
            return View();
        }



    }
}
