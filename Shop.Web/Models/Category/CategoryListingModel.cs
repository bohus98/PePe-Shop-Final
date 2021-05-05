using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Models.Category
{
    public class CategoryListingModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Prosim, zadajte nazov kategorie")]
        [Display(Name = "Nazov kategorie*")]
        [StringLength(20)]
        public string Name { get; set; }

        [Display(Name = "Popis")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Prosim vlozte URL obrazka danej kategorie")]
        [Display(Name = "URL obrazka*")]
        public string ImageUrl { get; set; }
    }
}
