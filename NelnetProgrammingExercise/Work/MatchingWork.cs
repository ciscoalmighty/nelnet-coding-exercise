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
            int count = 0;
            if(person.PreferredPetType == pet.Type)
            {
                count++;
            }
            if(person.PreferredClassification == pet.Classification)
            {
                count++;
            }
            if(person.PetSize == pet.Size)
            {
                count++;
            }
                
            if (count == 3)
            {
                return "best";
            }
            if (count == 2)
            {
                return "great";
            }
            if (count == 1)
            {
                return "good";
            }
            else return "bad";

        }

        public static void MatchWork (List<PersonModel> People,List<PetModel> Pets)
        {

            foreach(PersonModel person in People) 
            {
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

