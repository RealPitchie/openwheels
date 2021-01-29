using System.ComponentModel.DataAnnotations;

namespace openwheels.Models.ViewModels
{
     public class RegisterViewModel
    {
        [Required(ErrorMessage ="Поле '{0}' не заполнено")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Поле '{0}' не заполнено")]
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Поле '{0}' не заполнено")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Поле '{0}' не заполнено")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
        public string UserAvatar { get; set; }
    }
}