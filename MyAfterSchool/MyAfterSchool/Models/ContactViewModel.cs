using System.ComponentModel.DataAnnotations;
namespace MyAfterSchool.Models
{
    public class ContactViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Completarea mail-ului este obligatorie")]
        [EmailAddress(ErrorMessage = "Email-ul nu este valid")]
        public string Email { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Numarul de telefon nu este valid")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Completarea subiectului este obligatorie")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Completarea mesajului este obligatorie")]
        public string Message { get; set; }
    }
}