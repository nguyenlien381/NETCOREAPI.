using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers{
 
     public class heloworldController : Controller {

        public IActionResult Index() {
             
             return View();
              }

     }

}