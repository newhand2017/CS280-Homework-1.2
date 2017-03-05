using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //---------------------------------------------
            // Claim
            //---------------------------------------------
            Pokemon pokemon = new Pokemon();

            pokemon.Number = 004;
            pokemon.Name = "Charmander";
            pokemon.Height = 2.00f;
            pokemon.Weight = 18.7f;
            pokemon.Category = "Lizard";
            pokemon.Abilities = "Blaze";
            pokemon.Gender = "M";

            //---------------------------------------------
            // Function
            //---------------------------------------------
            Console.WriteLine("Name: {0} \tNumber: #{1,3:d3}",
                pokemon.Name, pokemon.Number);
            Console.WriteLine("Height: {0,4:f} ft \tCategory: {1}",
                pokemon.Height, pokemon.Category);
            Console.WriteLine("Weight: {0,4:f} lbs \tAbilities: {1}",
                pokemon.Weight, pokemon.Abilities);
            Console.WriteLine("Gender: {0} \t",
                pokemon.Gender);
            //---------------------------------------------
        }
    }
}