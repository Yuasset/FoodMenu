using System.ComponentModel.DataAnnotations;

namespace BLL.ViewModels
{
    public class RegisterVM
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Şifreler birleriyle uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
