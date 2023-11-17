using Microsoft.AspNetCore.Mvc;
using MANAOG_ITELEC_3ITE.Database;
using MANAOG_ITELEC_3ITE.Models;

using MANAOG_ITELEC_3ITE.Services;
namespace MANAOG_ITELEC_3ITE.Controllers
{
    public class InstructorController : Controller
    {
            private readonly AppDbContext _dbContext;
            public InstructorController(AppDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public IActionResult Index()
        {

            return View(_dbContext.Instructor);
        }
        //public IActionResult Index()
        //{
            
        //    return View(_fakeData.InstructorList);
        //}
        [HttpGet]
        public IActionResult AddInstructor()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            //Instructor Instructor = new Instructor();
            _dbContext.Instructor.Add(newInstructor);
            return View("Index",  _dbContext.Instructor);
        }
        //=== EDIT 
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Instructor? Instructor = _dbContext.Instructor.FirstOrDefault(st => st.Id == id);

            if (Instructor != null) // verify if the Instructor exist
                return View(Instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Instructor InstructorChange)
        {
            Instructor? Instructor =  _dbContext.Instructor.FirstOrDefault(st => st.Id == InstructorChange.Id);
            if (Instructor != null)
            {
                Instructor.Id = InstructorChange.Id;
                Instructor.FirstName = InstructorChange.FirstName;
                Instructor.LastName = InstructorChange.LastName;
                Instructor.IsTenured = InstructorChange.IsTenured;
                Instructor.Rank = InstructorChange.Rank;
                Instructor.HiringDate = InstructorChange.HiringDate;

            }
            return View("Index",  _dbContext.Instructor);
        }


        //==================================
        public IActionResult ShowDetail(int id)
        {
            //hehe
            //Search for the Instructor whose id matches the given id
            Instructor? Instructor =  _dbContext.Instructor.FirstOrDefault(st => st.Id == id);
            
            if (Instructor != null)//was an Instructor found?
                return View(Instructor);

            return NotFound();
        }
        //================================
        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor =  _dbContext.Instructor.FirstOrDefault(st => st.Id == id);
             _dbContext.Instructor.Remove(instructor);
            if (instructor != null)//was an instructor found?
                return RedirectToAction("Index",  _dbContext.Instructor);

            return NotFound();
        }
    }
}
