using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "This is Student Index";
        }
        public string GetStudentName()
        {
            return "Student Name  is Raghava Ranjith";
        }
        public string GetStudentPhone()
        {
            return "Phone Number: 8522921231";
        }
    }
}