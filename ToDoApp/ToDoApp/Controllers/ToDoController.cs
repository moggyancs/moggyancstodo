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
            return View(MyToDos.GetUsers());
        }

        [Route("/Create")]
        [HttpPost]
        public IActionResult Create(ToDo todo)
        {
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

        [Route("/Users")]
        [HttpGet]
        public IActionResult Users()
        {
            return View(MyToDos.GetUsers());
        }

        [Route("/Users")]
        [HttpPost]
        public IActionResult Users(User user)
        {
            MyToDos.AddUser(user);
            return RedirectToAction("Users");
        }

        [Route("/Profile/{id}")]
        [HttpGet]
        public IActionResult Profile([FromRoute] int id)
        {
            return View(MyToDos.ShowUser(id));
        }

        [Route("/Deleteuser/{id}")]
        [HttpGet]
        public IActionResult DeleteUser([FromRoute] int id)
        {
            MyToDos.DeleteUser(id);
            return RedirectToAction("Users");
        }
    }
}
