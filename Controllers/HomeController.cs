using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PapiKos.Models;

namespace PapiKos.Controllers
{
    public class HomeController : Controller
    {
        private readonly PapiKosContext _context;

        public HomeController(PapiKosContext context)
        {
            _context = context;
        }
        public IActionResult Index(string search)
        {
            if(search==null || search.Equals("")){
                return View();
            }
            return Content($"Hello {search}");

        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Detail(int? id){
            var kamar =  _context.Kamar.FirstOrDefault(m => m.KamarId == id);
            if (kamar == null)
            {
                return NotFound();
            }

            return View(kamar);
        }

        [HttpPost]
        public IActionResult Verify(Account a){
            return View("Create",a);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
