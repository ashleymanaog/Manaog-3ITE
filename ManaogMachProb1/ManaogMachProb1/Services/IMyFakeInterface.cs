using System;
using ManaogMachProb1.Models;

namespace ManaogMachProb1.Services
{
    public interface IMyFakeInterface
    {
        List<Student> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}
