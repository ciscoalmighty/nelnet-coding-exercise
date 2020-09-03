using NelnetProgrammingExercise.Models;
using NelnetProgrammingExercise.Work;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace NelnetProgrammingExercise
{
    class Program
    {
        public static PersonModel[] People;
        public static PetModel[] Pets;

        private static string IsGood(PersonModel person, PetModel pet)
        {
            return person.PreferredClassification == pet.Classification || person.PreferredPetType == pet.Type
                ? "good"
                : "bad";
        }

        static void Main(string[] args)
        {
            SetupWork.SetupObjects();

            foreach(PersonModel person in People) {
                Console.WriteLine(string.Format("Pets for {0}:", person.Name));

                foreach(PetModel pet in Pets)
                {
                    Console.WriteLine(string.Format("{0} would be a {1} pet.", pet.Name, IsGood(person, pet)));
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
