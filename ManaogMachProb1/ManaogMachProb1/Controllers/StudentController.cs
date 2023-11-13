using Microsoft.AspNetCore.Mvc;
using ManaogMachProb1.Models;
using ManaogMachProb1.Services;
using System.ComponentModel;
using ManaogMachProb1.Data;

namespace ManaogMachProb1.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbContext;
        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View(_dbContext.Student);
        }
        public IActionResult Student()
        {
            return View();
        }
        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dbContext.Student.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            _dbContext.Student.Add(newStudent);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dbContext.Student.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Student studentChange)
        {
            Student? student = _dbContext.Student.FirstOrDefault(st => st.Id == studentChange.Id);

            if (student != null)
            {
                student.Id = studentChange.Id;
                student.FirstName = studentChange.FirstName;
                student.LastName = studentChange.LastName;
                student.Email = studentChange.Email;
                student.Course = studentChange.Course;
                student.GPA = studentChange.GPA;
                student.AdmissionDate = studentChange.AdmissionDate;
                _dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dbContext.Student.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Delete(Student removeStudent)
        {
            Student? student = _dbContext.Student.FirstOrDefault(st => st.Id == removeStudent.Id);

            if (student != null)
            {
                _dbContext.Student.Remove(student);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }

}