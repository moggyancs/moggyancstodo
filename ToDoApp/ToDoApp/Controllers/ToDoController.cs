using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
using ToDoApp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApp
{

    [Route("/Todo")]
    public class ToDoController : Controller
    {
        IDoThingsRepo MyToDos;

        public ToDoController(IDoThingsRepo myToDos)
        {
            MyToDos = myToDos;
        }

        [Route("/")]
        [Route("/List")]
        [HttpGet]
        public IActionResult List()
        {
            return View(MyToDos.Read());
        }

        [Route("/Add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/Create")]
        [HttpPost]
        public IActionResult Create(ToDo todo)
        {
            //ToDo thing = new ToDo(Title, IsUrgent);
            MyToDos.Create(todo);
            return RedirectToAction("List");
        }

        [Route("/Entry/{id}")]
        [HttpGet]
        public IActionResult Entry([FromRoute] int id)
        {
            return View(MyToDos.ShowToDo(id));
        }


        [Route("/Remove/{id}")]
        [HttpGet]
        public IActionResult Remove([FromRoute] int id)
        {
            MyToDos.Delete(id);
            return RedirectToAction("List");
        }

    }
}
