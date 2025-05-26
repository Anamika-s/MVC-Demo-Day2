namespace MVC_Demo.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Batch { get; set; }
        public int Marks { get; set; }
    }
}


// Models contains all your classes
// represent domain

// want to dipslay object in the view
// we need to initialize in the controller action method