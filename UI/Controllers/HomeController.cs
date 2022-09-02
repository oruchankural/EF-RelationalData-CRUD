using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Test_Entities.Business.Concrete;
using Test_Entities.EF;
using Test_Entities.Model;
using UI.Models;
using Process = Test_Entities.Model.Process;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {


            using var c = new Context();


            var ticket = await c.Tickets.Where(x => x.TicketId == 1)
                .Include(x => x.Process)
                .Include(x => x.Sender)
                .Include(x => x.Receiver)
                .Include(x => x.Survey)
                .ToListAsync();


            return View(ticket);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
