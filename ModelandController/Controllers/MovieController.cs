using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Services;
using Movie.Models;


namespace model_controller_assignment.Controllers
{
    public class MovieController : Controller
    {
        public async Movie<IActionResult> Index()
        {
            var items = await _MovieItemService.GetIncompleteItemsAsync();
            var model = new MovieModel()
            {
                Items = items
            };
            return View(model);
        }
    }
}