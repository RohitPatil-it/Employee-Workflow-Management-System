//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Practice_CRUD.Data;
//using Practice_CRUD.Models;

//namespace Practice_CRUD.Controllers
//{
//    public class EmpController : Controller
//    {
//        private readonly ApplicationDbContext db;
//        public EmpController(ApplicationDbContext db)
//        {
//            this.db = db;
//        }
//        public IActionResult Index()
//        {
//            var data = db.emps.FromSqlRaw("exec FetchEmp").ToList();
//            return View(data);
//        }

//        public IActionResult AddEmp()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult AddEmp(Emp e)
//        {
//            db.Database.ExecuteSqlRaw($"exec SaveEmp '{e.Eid}','{e.EmpName}','{e.EmpEmail}','{e.SalaryOfEmp}'");
//            return RedirectToAction("Index");
//        }

//        public IActionResult DelEmp(int id)
//        {
//            db.Database.ExecuteSqlRaw($"exec DelEmp '{id}'");
//            return RedirectToAction("Index");
//        }

//        public IActionResult EditEmp(int id)
//        {
//            var data = db.emps.FromSqlRaw($"exec FindEmpById {id}").ToList().SingleOrDefault();
//            return View(data);
//        }

//        [HttpPost]
//        public IActionResult EditEmp(Emp e)
//        {
//            db.Database.ExecuteSqlRaw($"exec SaveEmp '{e.Eid}','{e.EmpName}','{e.EmpEmail}','{e.SalaryOfEmp}'");
//            return RedirectToAction("Index");
//        }
//    }
//}
