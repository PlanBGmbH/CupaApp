using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CupaApp.Models;
using System.Text.Encodings.Web;

namespace CupaApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /Home/Welcome/ 

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");

        }


    }
}
