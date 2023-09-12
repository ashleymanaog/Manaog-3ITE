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

    }
}
