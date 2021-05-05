using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Models.Account
{
    public class AccountRegisterModel
    {
        [Required(ErrorMessage = "Heslo je povinne")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$", 
            ErrorMessage = @"Heslo musi obsahovat najmenej 4 znaky, nesmie byt dlhsie nez 8 znakov a musi obsahovat aspon 1 velke pismeno, 1 male pismeno a 1 cislicu")]
        [DataType(DataType.Password)]
        [Display(Name = "Heslo")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Potvrdte heslo")]
        [DataType(DataType.Password)]
        [Compare("Heslo", ErrorMessage = "Heslo sa nezhoduje")]
        [Display(Name = "Potvrdte heslo")]
        public string PasswordConfirmation { get; set; }

        [Required(ErrorMessage = "Email je povinny")]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$", ErrorMessage = "Zadajte platny email")]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email")]
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

        public string ReturnUrl { get; set; }
    }
}
