using Microsoft.AspNetCore.Mvc;
using ManaogMachProb1.Models;


namespace ManaogMachProb1.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Arianne Ashley",LastName = "Manaog", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.25, Email = "arianneashley.manaog.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id= 2,FirstName = "Aliah",LastName = "Esteban", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "aliah.esteban.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id= 3,FirstName = "Aaron",LastName = "Manaog", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.75, Email = "aaron.manaog.cics@ust.edu.ph"
                }
            };
        public IActionResult Index()
        {

            return View(StudentList);
        }

        public IActionResult Student()
        {

            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();

        }

    }
}
