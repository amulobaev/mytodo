using System.ComponentModel.DataAnnotations;

namespace MyToDo.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Имя")]
        public string User { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня")]
        public bool RememberMe { get; set; }
    }
}