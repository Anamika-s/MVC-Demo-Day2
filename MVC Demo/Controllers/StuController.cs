using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;

namespace MVC_Demo.Controllers
{
    public class StuController : Controller
    {
        static List<Student> students = null;
        public StuController()
        {
            if(students == null)
            {
                students = new List<Student>()
                 {
                     new Student(){ Id = 1, Name ="Ajay", Batch="B001", Marks=90},

                     new Student(){ Id = 2, Name ="Jay", Batch="B001", Marks=90},
                     new Student(){ Id = 3, Name ="Deepak", Batch="B001", Marks=90},
                     new Student(){ Id = 4, Name ="Lalit", Batch="B001", Marks=90}
                 };
            }
        }
        public IActionResult Index()  // index is used to give list of records 
        {

            return View(students);
        }
        public IActionResult Details(int id)
        {
            return View(students.FirstOrDefault(x=>x.Id == id));

        }
        // get put post delete
        // get
        public IActionResult Create()
        {

            return View(new Student());
        }
        // post
        [HttpPost]
        public IActionResult Create(Student student)
        {
            students.Add(student);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {

            return View(students.FirstOrDefault(x => x.Id == id));
        }
        // post
        [HttpPost]
        public IActionResult Delete(int id, Student student1)
        {
            var student = students.FirstOrDefault(x => x.Id == student1.Id);
            students.Remove(student);
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int id)
        {

            return View(students.FirstOrDefault(x => x.Id == id));
        }
        // post
        [HttpPost]
        public IActionResult Edit(int id, Student student1)
        {
            var student = students.FirstOrDefault(x => x.Id == student1.Id);
            student.Marks = 100;
            return RedirectToAction("Index");

        }


    }
}
