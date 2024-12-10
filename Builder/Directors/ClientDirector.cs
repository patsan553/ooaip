using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    public class ClientDirector
    {
        private List<string> ListIngredients = new List<string> { "Cheese", "Meat",
            "Tomato", "Sauce", "Salad", "Pepper"};
        private List<string> ClientShawarma = new List<string>();
        public void BuildClientShawarma(ShawarmaBuilder shawarma)
        {
            foreach (var ingredient in ListIngredients)
            {
                Console.WriteLine($"would you like to add {ingredient} to the shawarma? (yes/no)");
                string Answer = Console.ReadLine().ToLower().Trim();
                if (Answer == "yes")
                {
                    switch (ingredient)
                    {
                        case "Cheese":
                            {
                                shawarma.WithCheese();
                                ClientShawarma.Add(ingredient);
                                break;
                            }
                        case "Meat":
                            {
                                shawarma.WithMeat();
                                ClientShawarma.Add(ingredient);
                                break;
                            }
                        case "Tomato":
                            {
                                shawarma.WithTomato();
                                ClientShawarma.Add(ingredient);
                                break;
                            }
                        case "Sauce":
                            {
                                shawarma.WithSauce();
                                ClientShawarma.Add(ingredient);
                                break;
                            }
                        case "Salad":
                            {
                                shawarma.WithSalad();
                                ClientShawarma.Add(ingredient);
                                break;
                            }
                        case "Pepper":
                            {
                                shawarma.WithPepper();
                                ClientShawarma.Add(ingredient);
                                break;
                            }
                    }
                }
            }
        }
        public List<string> GetIngredients()
        {
            return ClientShawarma;
        }
    }
}

