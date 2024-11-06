using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Views
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string EmailReg { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [StringLength(100, ErrorMessage = "Поле {0} должно иметь минимум {2} и максимум {1} символов.", MinimumLength = 5)]
        public string PasswordReg { get; set; }

        [Required]
        [Display(Name = "Запомнить меня?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
