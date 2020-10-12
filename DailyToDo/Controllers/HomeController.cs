using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyToDo.Data;
using DailyToDo.Models;
using DailyToDo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DailyToDo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IToDoService _service;
        public HomeController(IToDoService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {

            var model = new ToDoViewModel();
            model.todos = await _service.AsyncGetToDo();

            return View(model);

        }
        [HttpGet]
        public async Task<IActionResult> GetAllToDo()
        {
            var todos = await _service.AsyncGetToDo();

            return View(todos);
        }
        [HttpPost]

        public async Task<IActionResult> CreateToDo(string Description, int Priority)
        {
            try
            {
                await _service.AsyncInsertToDo(Description, Priority);
            }
            catch (Exception e)
            {
                return BadRequest("An Error occured");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CheckAsDone (int ID)
        {
            try
            {
                await _service.AsyncCheckAsDone(ID);
            }
            catch(Exception e)
            {
                return BadRequest("An Error occured");
            }

            return RedirectToAction("Index");

        }
    }
}
      

