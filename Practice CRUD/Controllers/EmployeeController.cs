using Microsoft.AspNetCore.Mvc;
using Practice_CRUD.Data;
using Practice_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string searchString)
        {
            var employees = from e in _context.Employees
                            select e;

            if (!string.IsNullOrEmpty(searchString))
            {
                employees = employees.Where(e => e.Name.Contains(searchString));
            }

            return View(employees.ToList());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Employee());
            else
            {
                var emp = _context.Employees.Find(id);
                if (emp != null && emp.Hobbies != null)
                {
                    // Convert comma-separated hobbies string back to List<string>
                    emp.HobbiesList = emp.Hobbies.Split(',').ToList();
                }
                return View(emp);
            }
        }

        [HttpPost]
        public IActionResult AddOrEdit(Employee emp, string[] Hobbies)
        {
            emp.Hobbies = Hobbies != null ? string.Join(',', Hobbies) : "";

            if (emp.Id == 0)
            {
                _context.Employees.Add(emp);
            }
            else
            {
                var existing = _context.Employees.Find(emp.Id);
                if (existing != null)
                {
                    existing.Name = emp.Name;
                    existing.Address = emp.Address;
                    existing.Department = emp.Department;
                    existing.Email = emp.Email;
                    existing.DOJ = emp.DOJ;
                    existing.Gender = emp.Gender;
                    existing.Hobbies = emp.Hobbies;
                }
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null)
                return NotFound();

            return View(employee);
        }

        public IActionResult Register()
        {
            return View();
        }

        // Register POST
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(user);
        }

        // Login GET
        public IActionResult Login()
        {
            return View();
        }

        // Login POST
        [HttpPost]
        public IActionResult Login(User user)
        {
            var matchedUser = _context.Users.FirstOrDefault(u =>
                u.Username == user.Username && u.Password == user.Password);

            if (matchedUser != null)
            {
                HttpContext.Session.SetString("Username", matchedUser.Username);
                return RedirectToAction("Index");
            }

            ViewBag.Message = "Invalid username or password";
            return View();
        }

        //public IActionResult Dashboard()
        //{
        //    var username = HttpContext.Session.GetString("Username");
        //    if (string.IsNullOrEmpty(username))
        //        return RedirectToAction("Login");

        //    ViewBag.Username = username;
        //    return View();
        //}
    }
}

