using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace l1
{
    public class MyController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //public void Execute(RequestContext requestContext)
        //{
        //  string ip = requestContext.HttpContext.Request.UserHostAddress;
        // var response = requestContext.HttpContext.Response;
        // response.Write("<h2>Ваш IP-адрес: " + ip + "</h2>");
        //}

        public IActionResult GetHelloWordWithString([FromQuery]string from)
        {
            string model = $"hello word from {from}";
            return View("GetHelloWordWithString", model);
        }

        public IActionResult FirstPages()
        {
            return View();
        }

        public IActionResult SecondPAges()
        {
            return View();
        }
        [HttpGet()]
        public IActionResult Mirror([FromQuery(Name = "Mirror")] string Mirror)
        {
            ViewBag.MirrorData = Mirror;
            return View();
        }
    }
}
