using System;
using System.Collections.Generic;
using System.Text;
using ColdStart_Api.Models;

namespace ColdStart_Api.Helpers
{
    public static class MockData
    {
        public static List<Catalog> GetCatalogs()
        {
            return new List<Catalog>() {  new Catalog(){
                        Id= 1,
                        Name= "Color Pop",
                        Description= "Delicious 4-color popsicle, plenty of vitamins.",
                        ImageUrl= "https://coldstartsa.blob.core.windows.net/web/assets/Icecream1.png"
                      },
                       new Catalog(){
                        Id= 2,
                        Name= "Lemoncella",
                        Description= "Refreshing lemon-flavoured icecream bar.",
                        ImageUrl= "https://coldstartsa.blob.core.windows.net/web/assets/Icecream2.png"
                      },
                       new Catalog(){
                        Id= 3,
                        Name= "Pink Panther",
                        Description= "Fruity ice cream bar with hints of strawberry and lime.",
                        ImageUrl= "https://coldstartsa.blob.core.windows.net/web/assets/Icecream3.png"
                      },
                       new Catalog(){
                        Id= 4,
                        Name= "Choco Chique",
                        Description= "Filled with praline and covered with the finest Belgian chocolate.",
                        ImageUrl= "https://coldstartsa.blob.core.windows.net/web/assets/Icecream4.png"
                      },
                       new Catalog(){
                        Id= 5,
                        Name= "Blue Lagoon",
                        Description= "Blueberry and melon ice cream bar.",
                        ImageUrl= "https://coldstartsa.blob.core.windows.net/web/assets/Icecream5.png"
                      },
                      new Catalog() {
                        Id= 6,
                        Name= "Purple Rain",
                        Description= "Indulging strawberry and vodka icecream bar.",
                        ImageUrl= "https://coldstartsa.blob.core.windows.net/web/assets/Icecream6.png"
                      },
                       new Catalog(){
                        Id= 7,
                        Name= "Sorbonne",
                        Description= "Strawberry and raspberry sorbet.",
                        ImageUrl= "https://coldstartsa.blob.core.windows.net/web/assets/Icecream7.png"
                      },
                       new Catalog(){
                        Id= 8,
                        Name= "Sandstorm",
                        Description= "Chocolate and vanille ice cream cookie (3).",
                        ImageUrl= "https://coldstartsa.blob.core.windows.net/web/assets/Icecream8.png"
                      },
                       new Catalog(){
                        Id= 9,
                        Name= "Maxi jazz",
                        Description= "Dame Blanche flavoured ice cream cake (6p).",
                        ImageUrl= "https://coldstartsa.blob.core.windows.net/web/assets/Icecream9.png"
                      },
                       new Catalog() {
                        Id = 10,
                        Name= "Triplets",
                        Description= "Surprise yourself with a random selection of 3 different flavors.",
                        ImageUrl= "https://coldstartsa.blob.core.windows.net/web/assets/Icecream10.png"
                      }};
       }
    }
} 
