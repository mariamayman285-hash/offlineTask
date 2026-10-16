 using Microsoft.AspNetCore.Mvc;
using offlineTask.Models;

namespace offlineTask.Controllers
{
    public class TasksController  : Controller
    {
        public IActionResult Index()
        {
            TaskitemBL tBL = new TaskitemBL();
            List<Taskitem> TaskList = tBL.GetAll();
            return View("Index" , TaskList);

        }

        public IActionResult Details(int id)
        {
            TaskitemBL tBL = new TaskitemBL();
            Taskitem ti = tBL.GetById(id);
            return View("Details" , ti);
        }

    }
}
