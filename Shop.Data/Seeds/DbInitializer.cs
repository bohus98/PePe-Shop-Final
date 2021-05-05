using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Seeds
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                ApplicationDbContext context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(Categories.Select(c => c.Value));
                }

                //context.Drinks.RemoveRange(context.Drinks);
                if (!context.Foods.Any())
                {
                    var foods = new Food[]
                    {
                         new Food
                         {
                             Name = "Baklazan",
                             Category = categories["Zelenina"],
                             ImageUrl = "https://images.pexels.com/photos/321551/pexels-photo-321551.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450",
                             InStock = 20,
                             IsPreferedFood = false,
                             ShortDescription = "Kratky popis.",
                             LongDescription = "Dlhy popis.",
                             Price = 4.5M
                         },
                        new Food
                        {
                            Name = "Karfiol",
                            Category = categories["Zelenina"],
                            ImageUrl = "https://images.pexels.com/photos/461245/pexels-photo-461245.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450",
                            InStock = 20,
                            IsPreferedFood = true,
                            ShortDescription = "Kratky popis.",
                            LongDescription = "Dlhy popis.",
                            Price = 5.3M
                        },
                        new Food
                        {
                            Name = "Brokolica",
                            Category = categories["Vegetable"],
                            ImageUrl = "https://images.pexels.com/photos/47347/broccoli-vegetable-food-healthy-47347.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450",
                            InStock = 20,
                            IsPreferedFood = true,
                            ShortDescription = "Kratky popis.",
                            LongDescription = "Dlhy popis.",
                            Price = 3.3M
                        },
                        new Food
                        {
                            Name = "Jablko",
                            Category = categories["Ovocie"],
                            ImageUrl = "https://images.pexels.com/photos/39803/pexels-photo-39803.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450",
                            InStock = 20,
                            IsPreferedFood = true,
                            ShortDescription = "Kratky popis.",
                            LongDescription = "Dlhy popis",
                            Price = 2.7M
                        },
                        new Food
                        {
                            Name = "Avokado",
                            Category = categories["Ovocie"],
                            ImageUrl = "https://images.pexels.com/photos/557659/pexels-photo-557659.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450",
                            InStock = 20,
                            IsPreferedFood = false,
                            ShortDescription = "Kratky popis",
                            LongDescription = "Dlhy popis",
                            Price = 6.1M
                        },
                        new Food
                        {
                            Name = "Banan",
                            Category = categories["Ovocie"],
                            ImageUrl = "https://images.pexels.com/photos/38283/bananas-fruit-carbohydrates-sweet-38283.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450",
                            InStock = 20,
                            IsPreferedFood = true,
                            ShortDescription = "Kratky popis",
                            LongDescription = "Dlhy popis",
                            Price = 4.6M
                        },
                        new Food
                        {
                            Name = "Grapefruit",
                            Category = categories["Ovocie"],
                            ImageUrl = "https://images.pexels.com/photos/209549/pexels-photo-209549.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450",
                            InStock = 20,
                            IsPreferedFood = false,
                            ShortDescription = "Kratky popis",
                            LongDescription = "Dlhy popis popis",
                            Price = 6.4M
                        },
                        new Food
                        {
                            Name = "Ovos",
                            Category = categories["Obilnina"],
                            ImageUrl = "https://images.pexels.com/photos/533346/pexels-photo-533346.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450",
                            InStock = 20,
                            IsPreferedFood = false,
                            ShortDescription = "Kratky popis",
                            LongDescription = "Dlhy popis",
                            Price = 1.6M
                        },
                        new Food
                        {
                            Name = "Hovadzina",
                            Category = categories["Maso"],
                            ImageUrl = "https://images.pexels.com/photos/618775/pexels-photo-618775.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450",
                            InStock = 20,
                            IsPreferedFood = true,
                            ShortDescription = "Kratky popis",
                            LongDescription = "Dlhy popis popis",
                            Price = 8.8M
                        },
                        new Food
                        {
                            Name = "Kuracina",
                            Category = categories["Maso"],
                            ImageUrl = "https://images.pexels.com/photos/616353/pexels-photo-616353.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450",
                            InStock = 20,
                            IsPreferedFood = true,
                            ShortDescription = "Kratky popis",
                            LongDescription = "Dlhy popis",
                            Price = 5.3M
                        },
                        new Food
                        {
                            Name = "Maslo",
                            Category = categories["Mliecne vyrobky"],
                            ImageUrl = "https://images.pexels.com/photos/531334/pexels-photo-531334.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=450",
                            InStock = 20,
                            IsPreferedFood = false,
                            ShortDescription = "Kratky popis",
                            LongDescription = "Dlhy popis",
                            Price = 5.0M
                        },
                        new Food
                        {
                            Name = "Syr",
                            Category = categories["Mliecne vyrobky"],
                            ImageUrl = "https://images.pexels.com/photos/821365/pexels-photo-821365.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450",
                            InStock = 20,
                            IsPreferedFood = true,
                            ShortDescription = "Kratky popis",
                            LongDescription = "Dlhy popis",
                            Price = 4.4M
                        }
                    };



                    context.AddRange(foods);
                }

                context.SaveChanges();
            }
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category
                        {
                            Name = "Zelenina",
                            Description = "Všetky druhy zeleniny a strukovín / fazule ",
                            ImageUrl = "https://images.pexels.com/photos/533360/pexels-photo-533360.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450",
                        },
                    new Category
                    {
                        Name = "Ovocie",
                        Description = "Všetko ovocie",
                        ImageUrl = "https://images.pexels.com/photos/8066/fruits-market-colors.jpg?auto=compress&cs=tinysrgb&dpr=1&w=450"
                    },
                    new Category
                    {
                        Name = "Obilnina",
                        Description = "Obilné potraviny, väčšinou celozrnné a / alebo s vysokým obsahom obilnín" ,
                        ImageUrl = "https://images.pexels.com/photos/1537169/pexels-photo-1537169.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450"
                    },
                    new Category
                    {
                        Name = "Maso",
                        Description = "Chudé mäso a hydina, ryby, vajcia, tofu ",
                        ImageUrl = "https://images.pexels.com/photos/65175/pexels-photo-65175.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450"
                    },
                    new Category
                    {
                        Name = "Mliecne vyrobky",
                        Description = "Mlieko, jogurtový syr a / alebo alternatívy, väčšinou so zníženým obsahom tuku ",
                        ImageUrl = "https://images.pexels.com/photos/416656/pexels-photo-416656.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450"
                    }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        //genre.ImageUrl = $"/images/Categories/{genre.Name}.png";
                        categories.Add(genre.Name, genre);
                    }
                }

                return categories;
            }
        }
    }
}