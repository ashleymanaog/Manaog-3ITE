using ManaogMachProb1.Models;

namespace ManaogMachProb1.Services
{
    public class MyFakeDataService : IMyFakeInterface

    {
        public List<Student> StudentList { get; }

        public List<Instructor> InstructorList { get; }
        public MyFakeDataService()
        {
            StudentList = new List<Student>()
            {
                new Student()
            {
                Id = 1, FirstName ="Arianne Ashley", AdmissionDate = DateTime.Now, Course=Course.BSCS
            },
                 new Student()
            {
                Id = 2, FirstName ="Aaron", AdmissionDate = DateTime.Now, Course=Course.BSIT
            },
                   new Student()
            {
                Id = 3, FirstName ="Athan", AdmissionDate = DateTime.Now, Course=Course.BSIS
            }

};
            InstructorList = new List<Instructor>()

            {
                new Instructor()
            {
                Id = 1, FirstName ="Arianne Ashley", HiringDate = DateTime.Now, Rank=Rank.AssociateProfessor
            },
                 new Instructor()
            {
                Id = 2, FirstName ="Aaron", HiringDate = DateTime.Now, Rank= Rank.Professor
            },
                   new Instructor()
            {
                Id = 3, FirstName ="Athan", HiringDate = DateTime.Now, Rank=Rank.AssistantProfessor
            }
};

        }
    }
}

       