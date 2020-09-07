using NelnetProgrammingExercise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NelnetProgrammingExercise.Work
{
    class MatchingWork
    {
        private static string IsGood(PersonModel person, PetModel pet)
        {
            return person.PreferredPetType == pet.Type || person.PreferredClassification == pet.Classification || person.PetSize == pet.Size
                ? "good"
                : "bad";
        }

        public static void MatchWork ()
        {

            foreach(PersonModel person in Program.People) 
            {
                Console.WriteLine(string.Format("Pets for {0}:", person.Name));
                foreach(PetModel pet in Program.Pets)
                {
                    Console.WriteLine(string.Format("{0} would be a {1} pet.", pet.Name, IsGood(person, pet)));
                }
                 Console.WriteLine();
            }
            Console.ReadLine();
        }

    }

}

