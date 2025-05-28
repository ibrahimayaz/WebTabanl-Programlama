using System.ComponentModel.DataAnnotations;

namespace DataAnnotationBEU.ViewModels
{
    public class UserVM
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Lütfen belirtirilen aralıkta adınızı giriniz.")]
        public string Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Lütfen belirtirilen aralıkta adınızı giriniz.")]
        public string Surname { get; set; }
        [Required]
        [Range(18, 65, ErrorMessage = "Üzgünüm yaşınız belirtilen aralıkta değil.")]
        public string Age { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="Şifre alanları uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [EmailAddress(ErrorMessage ="E-mail adresi doğru biçimde değil.")]
        public string Email { get; set; }
    }
}
