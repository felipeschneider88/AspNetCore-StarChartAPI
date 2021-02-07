using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    public class CelestialObjectController : Controller
    {
        private ApiController ApiController;

        private readonly ApplicationDbContext _context;

        public CelestialObjectController(ApplicationDbContext ApplicationDbContext)
        {
            _context = ApplicationDbContext;
        }
        [Route= ""]
        public IActionResult Index()
        {
            return View();
        }
    }
}
