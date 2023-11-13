using System.ComponentModel.DataAnnotations;

namespace ManaogMachProb1.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {

        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Status")]
        public bool IsTenured { get; set; }
       
        [Display(Name = "Rank")]
        public Rank Rank { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

    }
}
