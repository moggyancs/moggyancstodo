using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
using ToDoApp.Repositories;

namespace ToDoApp.Controllers
{
    public class UserController : Controller
    {
        IDoThingsRepo MyToDos;

        public UserController(IDoThingsRepo myToDos)
        {
            MyToDos = myToDos;
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