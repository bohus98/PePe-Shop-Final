using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Models.Food
{
    public class NewFoodModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Prosim, zadajte nazov Vasho jedla")]
        [Display(Name = "Nazov jedla*")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Prosim, zadajte URL obrazku Vasho jedla")]
        [Display(Name = "URL obrazka*")]
        public string ImageUrl { get; set; }

        [Display(Name = "Kratky popis")]
        public string ShortDescription { get; set; }


        [Display(Name = "Dlhy popis")]
        public string LongDescription { get; set; }

        [Required(ErrorMessage = "Prosim, zadajte cenu jedla")]
        [Range(0.1,double.MaxValue)]
        [Display(Name = "Cena*")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Zvolte ci dane jedlo je preferovane alebo nie")]
        [Display(Name = "Je preferovane?*")]
        public bool? IsPreferedFood { get; set; } = false;

        [Range(0, double.MaxValue)]
        [Required(ErrorMessage = "Prosim zadajte kolko kusov sa nachadza na sklade ")]
        [Display(Name = "Na sklade*")]
        public int? InStock { get; set; }

        [Required(ErrorMessage = "Prosim, zvolte kategoriu")]
        [Range(1,double.MaxValue)]
        public int? CategoryId { get; set; }
    }
}
