using System.ComponentModel.DataAnnotations;

namespace VueProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}