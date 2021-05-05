using System.ComponentModel.DataAnnotations;

namespace Shop.Web.Models.Account
{
    public class AccountSettingsModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Prosim zvolte rolu")]
        public string RoleId { get; set; }

        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$", ErrorMessage = @"Nespravne heslo")]
        [DataType(DataType.Password)]
        [Display(Name = "Stare heslo")]
        public string OldPassword { get; set; }

        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$",
            ErrorMessage = @"Heslo musi obsahovat najmenej 4 znaky, nesmie byt dlhsie nez 8 znakov a musi obsahovat aspon 1 velke pismeno, 1 male pismeno a 1 cislicu")]
        [Display(Name = "Nove heslo")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Heslo sa nezhoduje")]
        [Display(Name = "Potvrdte nove heslo")]
        public string NewPasswordConfirmation { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Meno je povinne")]
        [StringLength(255, ErrorMessage = "Meno musi pozostavat z 2 - 255 znakov", MinimumLength = 2)]
        [Display(Name = "Meno")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Priezvisko je povinne")]
        [StringLength(255, ErrorMessage = "Priezvisko musi pozostavat z 2 - 255 znakov", MinimumLength = 2)]
        [Display(Name = "Priezvisko")]
        public string LastName { get; set; }

        [Display(Name = "URL profiloveho obrazku")]
        public string ImageUrl { get; set; }

        [Display(Name = "Adresa 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Adresa 2")]
        public string AddressLine2 { get; set; }

        [Display(Name = "Mesto")]
        [Required(ErrorMessage = "Mesto je povinne")]
        [StringLength(255, ErrorMessage = "Mesto musi pozostavat z 2 - 255 znakov", MinimumLength = 2)]
        public string City { get; set; }

        [Display(Name = "Stat")]
        [Required(ErrorMessage = "Stat je povinny")]
        [StringLength(255, ErrorMessage = "Stat musi pozostavat z 2 - 255 znakov", MinimumLength = 2)]
        public string Country { get; set; }

        [Display(Name = "Telefonne cislo")]
        public string PhoneNumber { get; set; }
    }
}
