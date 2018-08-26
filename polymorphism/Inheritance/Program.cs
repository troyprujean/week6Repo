using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DomesticPig domesticPig = new DomesticPig("Bob", 12, "Male");
            WildPig wildPig = new WildPig("Sarah", 10, "Female");
            MerinoSheep merinoSheep = new MerinoSheep("Carl", 4, "Male");
            DorsetHornSheep dorsetHornSheep = new DorsetHornSheep("Ian", 7, "Male");
            AlpacaLlama alpacaLlama = new AlpacaLlama("Eve", 6, "Female");
            GuanacoLlama guanacoLlama = new GuanacoLlama("Sam", 15, "Male");
            FresianCow fresianCow = new FresianCow("Howard", 6, "Male");
            AngusCow angusCow = new AngusCow("Layla", 11, "Female");
            TexasLonghornCow texasLonghornCow = new TexasLonghornCow("David", 10, "Male");
            DuckBird duckBird = new DuckBird("Jess", 5, "Female");
            BantamChickenBird bantamChickenBird = new BantamChickenBird("Matt", 18, "Male");
            PeacockBird peacockBird = new PeacockBird("Syd", 25, "Male");

            List<Animal> animalList = new List<Animal>
            {
                domesticPig,
                wildPig,
                merinoSheep,
                dorsetHornSheep,
                alpacaLlama,
                guanacoLlama,
                fresianCow,
                angusCow,
                texasLonghornCow,
                duckBird,
                bantamChickenBird,
                peacockBird
            };

            foreach(Animal animal in animalList)
            {
                Console.WriteLine($"The animals name is: {animal.Name}");
                Console.WriteLine($"The animals age is: {animal.Age}");
                Console.WriteLine($"The animals gender is: {animal.Gender}");
                Console.WriteLine($"");
            }
        }
        
    }
}
