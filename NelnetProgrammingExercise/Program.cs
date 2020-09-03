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

        #region Initialization

        //private static void SetupObjects()
        //{
        //    People = new PersonModel[]
        //    {
        //        new PersonModel()
        //        {
        //            Name = "Dalinar",
        //            PreferredClassification = PetClassification.Mammal,
        //            PreferredPetType = PetType.Snake,
        //            PreferredPetSize = PetSize.Medium
        //        },
        //        new PersonModel()
        //        {
        //            Name = "Kaladin",
        //            PreferredClassification = PetClassification.Bird,
        //            PreferredPetType = PetType.Goldfish,
        //            PreferredPetSize = PetSize.ExtraSmall
        //        }
        //    };

        //    Pets = new PetModel[]
        //    {
        //        new PetModel()
        //        {
        //            Name = "Garfield",
        //            Weight = 20.00,
        //            Classification = PetClassification.Mammal,
        //            Type = PetType.Cat,
        //        },
        //        new PetModel()
        //        {
        //            Name = "Odie",
        //            Weight = 15.00,
        //            Classification = PetClassification.Mammal,
        //            Type = PetType.Dog,
        //        },
        //        new PetModel()
        //        {
        //            Name = "Peter Parker",
        //            Weight = 0.50,
        //            Classification = PetClassification.Arachnid,
        //            Type = PetType.Spider,
        //        },
        //        new PetModel()
        //        {
        //            Name = "Kaa",
        //            Weight = 25.00,
        //            Classification = PetClassification.Reptile,
        //            Type = PetType.Snake,
        //        },
        //        new PetModel()
        //        {
        //            Name = "Nemo",
        //            Weight = 0.50,
        //            Classification = PetClassification.Fish,
        //            Type = PetType.Goldfish,
        //        },
        //        new PetModel()
        //        {
        //            Name = "Alpha",
        //            Weight = 0.10,
        //            Classification = PetClassification.Fish,
        //            Type = PetType.Betta,
        //        },
        //        new PetModel()
        //        {
        //            Name = "Splinter",
        //            Weight = 0.50,
        //            Classification = PetClassification.Mammal,
        //            Type = PetType.Rat,
        //        },
        //        new PetModel()
        //        {
        //            Name = "Coco",
        //            Weight = 06.00,
        //            Classification = PetClassification.Bird,
        //            Type = PetType.Parrot,
        //        },
        //        new PetModel()
        //        {
        //            Name = "Tweety",
        //            Weight = 0.05,
        //            Classification = PetClassification.Bird,
        //            Type = PetType.Canary,
        //        }
        //    };
            
        //}
        //private static void SetupPets()
        //{
        //    foreach (PetModel pet in Pets)
        //    {
        //        pet.Size = WeightWork.weightWork(pet.Weight);
               
        //    }
        //}
        #endregion

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
