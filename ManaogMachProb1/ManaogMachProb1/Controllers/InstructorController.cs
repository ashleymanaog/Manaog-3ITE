using Microsoft.AspNetCore.Mvc;
using ManaogMachProb1.Models;


namespace ManaogMachProb1.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Arianne Ashley",LastName = "Manaog", IsTenured = true, HiringDate = DateTime.Parse("2022-08-26"), Rank = Rank.Professor
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Aliah",LastName = "Esteban", IsTenured = true, HiringDate = DateTime.Parse("2022-08-07"), Rank = Rank.AssistantProfessor
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Aaron",LastName = "Manaog", IsTenured = true, HiringDate = DateTime.Parse("2022-08-08"), Rank = Rank.AssistantProfessor
                }
            };
        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the Instructor whose id matches the given id
            Instructor? Instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (Instructor != null)//was an Instructor found?
                return View(Instructor);

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }


        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);
            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult EditInstructor(Instructor instructorChange)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == instructorChange.Id);

            if (instructor != null)
            {
                instructor.Id = instructorChange.Id;
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.Rank = instructorChange.Rank;
                instructor.IsTenured = instructorChange.IsTenured;
                instructor.HiringDate = instructorChange.HiringDate;
            }
            return View("Index", InstructorList);
        }
    }
}
