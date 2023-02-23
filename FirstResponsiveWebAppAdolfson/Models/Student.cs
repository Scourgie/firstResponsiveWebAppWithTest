using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FirstResponsiveWebAppAdolfson.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter a grade.")]
        [Range(0,100, ErrorMessage = "Grade must be a number from 0 to 100.")]
        public double? Grade { get; set; }

        

    }
}
