using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppAdolfson.Models
{
    public class ResponsiveWebAppModel
    {

        [Required(ErrorMessage = "Please enter your name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter your birth year.")]
        [Range(1, 9999, ErrorMessage = "Birth Date must be between 0001 and 9999.")]
        public int? BirthYear { get; set; }

        public string AgeThisYear(string name, int? birthYear)
        {
            int currentYear = DateTime.Now.Year;

            int age = currentYear - BirthYear.Value;

            string finalString = Name + "'s age: " + age.ToString();

            return finalString;
        }

    }
}
