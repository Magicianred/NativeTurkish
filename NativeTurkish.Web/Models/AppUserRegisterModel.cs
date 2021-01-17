using System.ComponentModel.DataAnnotations;

namespace NativeTurkish.Web.Models
{
    public class AppUserRegisterModel
    {
        [Required(ErrorMessage ="�sim alan� bo� ge�ilemez")]
        public string Name { get; set; }
        [Required(ErrorMessage ="E-mail alan� bo� ge�ilemez"), EmailAddress(ErrorMessage ="L�tfen email adresini do�ru girin")]
        public string Email { get; set; }

        [Required(ErrorMessage = "�ifre alan� bo� ge�ilemez")]
        [StringLength(18, ErrorMessage = "�ifre maksimum {1}, minimum  {2} karakter uzunlu�unda olmal�d�r.", MinimumLength = 3)]
        public string Password { get; set; }
    }
}