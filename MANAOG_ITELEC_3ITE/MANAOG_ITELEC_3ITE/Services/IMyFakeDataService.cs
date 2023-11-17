using MANAOG_ITELEC_3ITE.Models;
using System;
namespace MANAOG_ITELEC_3ITE.Services
{
    public interface IMyFakeDataService
    {
        List<Student> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}


