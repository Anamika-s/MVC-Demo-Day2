using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;

namespace MVC_Demo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student()
            {
                Id = 101,
                Name = "Jatin",
                Batch = "Dotnet",
                Marks = 90
            };
            ViewBag.student = student;
            return View();
        }

        public IActionResult Index1()
        {
            Student student = new Student()
            {
                Id = 101,
                Name = "Jatin",
                Batch = "Dotnet",
                Marks = 90
            };
            //ViewBag.student = student;
            return View(student);
        }

        public IActionResult List()
        {
            // List of students , want to display in view
            List<Student> students = new List<Student>()
            {
           new Student() {  Id = 101,
                Name = "Jatin",
                Batch = "Dotnet",
                Marks = 90},
           new Student() {  Id = 102,
                Name = "Jatin",
                Batch = "Dotnet",
                Marks = 90},
new Student() {  Id = 103,
                Name = "Jatin",
                Batch = "Dotnet",
                Marks = 90},
new Student() {  Id = 104,
                Name = "Deepak",
                Batch = "Dotnet",
                Marks = 90},

           };

            ViewBag.list = students;    
            return View();  


        }

        public IActionResult List1()
        {
            // List of students , want to display in view
            List<Student> students = new List<Student>()
            {
           new Student() {  Id = 101,
                Name = "Jatin",
                Batch = "Dotnet",
                Marks = 90},
           new Student() {  Id = 102,
                Name = "Jatin",
                Batch = "Dotnet",
                Marks = 90},
new Student() {  Id = 103,
                Name = "Jatin",
                Batch = "Dotnet",
                Marks = 90},
new Student() {  Id = 104,
                Name = "Deepak",
                Batch = "Dotnet",
                Marks = 90},

           };

            //ViewBag.list = students;
            return View(students);


        }
    }
    
}
