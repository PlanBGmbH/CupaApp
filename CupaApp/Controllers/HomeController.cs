using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CupaApp.Models;

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

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
