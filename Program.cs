using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_i_polimorfizam
{
    class Program
    {


        class Dessert
        {
             string name;
             double weight;
             int cal;

            public string Name { get => name; set => name = value; }
            public double Weight { get => weight; set => weight = value; }
            public int Cal { get => cal; set => cal = value; }

            public Dessert(string name, double weight, int cal)
            {
                this.Name = name;
                this.Weight = weight;
                this.Cal = cal;
            }
            public string GetDessertType()
            {
                return "Dessert";
            }
            public override string ToString()
            {
                return this.Name + this.Weight + this.Cal;
            }
            public Dessert()
            {

            }
        }


        class Cake : Dessert
        {
            internal string ContainsGluten;
            bool constainsGluten;
            string cakeType;

            public Cake()
            {
            }

            public Cake(bool constainsGluten, string cakeType)
            {
                this.ConstainsGluten = constainsGluten;
                this.CakeType = cakeType;
            }

            public bool ConstainsGluten { get => constainsGluten; set => constainsGluten = value; }
            public string CakeType { get => cakeType; set => cakeType = value; }
            

            public string GetDessertType()
            {
                return this.CakeType + "Cake";
            }
            public override string ToString()
            {
                return this.Name + this.Weight + this.Cal + this.ConstainsGluten + this.CakeType;
            }
        }
        class Ice_Cream : Dessert
        {
            
                string flavour;
                string colour;

            public Ice_Cream()
            {
            }

            public Ice_Cream(string flavour, string colour)
                {
                    this.Flavour = flavour;
                    this.Colour = colour;
                }

            public string Flavour { get => flavour; set => flavour = value; }
            public string Colour { get => colour; set => colour = value; }

            public string GetDessertType()
                {
                    return "Ice cream";
                }
                public override string ToString()
                {
                    return this.Name + this.Weight + this.Cal + this.Flavour + this.Colour;
                }

        }
        static void Main(string[] args)
        {
            Cake a = new Cake();
            Ice_Cream b = new Ice_Cream();

            a.Name = "Cokoladna";
            a.Weight = 694;
            a.Cal = 61;
            a.ContainsGluten = "false";
            a.CakeType = "Rođendanska";

            b.Name = "Kornet";
            b.Weight = 97;
            b.Cal = 12;
            b.Flavour = "Vanilija";
            b.Colour = "Yellow";
            Console.WriteLine("Torta " + a.CakeType + a.Name + ", gluten = " + a.ContainsGluten + "\n Težina: " + a.Weight + "g" + "\n Kalorije: " + a.Cal + "kCal"
                + "\n\n Sladoled " + b.Name + b.Flavour + "\nBoja: " + b.Colour + "\n Težina: " + b.Weight + "g" + "\n Kalorije: " + b.Cal + "kCal");
            Console.ReadKey();
        }
    }
}
