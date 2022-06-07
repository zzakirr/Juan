using Microsoft.AspNetCore.Mvc;
using myJuan.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myJuan.Areas.Manage.Controllers
{
    [Area("manage")]
    public class SliderController : Controller
    {

        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
