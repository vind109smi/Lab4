using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCLab.Controllers
{
    public class BoxController : Controller
    {
        public IActionResult Index(int id)
        {
            string boxList = "";
            for (int i = 0; i < id; i++)
            {
                boxList += "<div id = \"boxList\">" + (i + 1) + "</div><br><br>";
            }
            ViewBag.Box = boxList;
            return View(boxList);
        }
    }
}