using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/

        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/Welcome'>" +
      "<input type='text' name='name' />" +
      "<select name='language'> <option value='1'>English</option><option value='2'>French</option><option value='3'>German</option></select>" +
      "<input type='submit' value='Greet Me!' />" +
      "</form>";

            return Content(html, "text/html");
        }

        //GET: /<controller>/welcome
        [HttpPost("welcome")]
        [Route("/helloworld/welcome/{name?}/{language?}")]
        public IActionResult Welcome(string name = "World", string language = "")
        {
            if (language == "1")
            {
                return Content("<h1>Welcome to my app, " + name + "!<h1>", "text/html");
            }
            else if (language == "2")
            {
                return Content("<h1>Bienvenue, " + name + "!<h1>", "text/html");
            }
            else if (language == "3")
            {
                return Content("<h1>Wilkommen " + name + "!<h1>", "text/html");
            }
            return Content("<h1>It didn't work...<h1>", "text/html");
        }
    }
}
