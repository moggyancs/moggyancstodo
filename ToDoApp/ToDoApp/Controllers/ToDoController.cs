using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.Controllers
{
    [Route("/todo")]
    public class ToDoController : Controller
    {
        IRepository myToDos;

        public ToDoController(IRepository myToDos)
        {
            this.myToDos = myToDos;
        }

        [Route("/")]
        [Route("/list")]
        public IActionResult Index()
        {
            return View(myToDos.Read());
        }
    }
}
