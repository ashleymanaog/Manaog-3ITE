using Microsoft.AspNetCore.Mvc;
using ManaogMachProb1.Models;
using ManaogMachProb1.Services;


namespace ManaogMachProb1.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IMyFakeInterface _fakeData;

        public InstructorController(IMyFakeInterface fakeData)
        {
            _fakeData = fakeData;
        }


        public IActionResult Index()
        {

            return View(_fakeData.InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the Instructor whose id matches the given id
            Instructor? Instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);

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
            _fakeData.InstructorList.Add(newInstructor);
            return View("Index", _fakeData.InstructorList);
        }


        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);
            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult EditInstructor(Instructor instructorChange)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == instructorChange.Id);

            if (instructor != null)
            {
                instructor.Id = instructorChange.Id;
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.Rank = instructorChange.Rank;
                instructor.IsTenured = instructorChange.IsTenured;
                instructor.HiringDate = instructorChange.HiringDate;
            }
            return View("Index", _fakeData.InstructorList);
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);
            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult DeleteInstructor(Instructor instructorChange)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == instructorChange.Id);

            if (instructor != null)
            {
                instructor.Id = instructorChange.Id;
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.Rank = instructorChange.Rank;
                instructor.IsTenured = instructorChange.IsTenured;
                instructor.HiringDate = instructorChange.HiringDate;
            }
            _fakeData.InstructorList.Remove(instructor);
            return View("Index", _fakeData.InstructorList);

        }




    }
}

