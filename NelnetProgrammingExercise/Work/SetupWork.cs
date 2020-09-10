using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using NelnetProgrammingExercise.Models;

namespace NelnetProgrammingExercise.Work
{
    public class SetupWork
    {
        public static (List<PersonModel> People, List<PetModel> Pets) SetUpLists()
        {
            var People = new List<PersonModel>
            {
                new PersonModel()
                {
                    Name = "Dalinar",
                    PreferredClassification = PetClassification.Mammal,
                    PreferredPetType = PetType.Snake,
                    PetSize = PetSize.Medium
                },
                new PersonModel()
                {
                    Name = "Kaladin",
                    PreferredClassification = PetClassification.Bird,
                    PreferredPetType = PetType.Goldfish,
                    PetSize = PetSize.ExtraSmall
                }
            };


            var Pets = new List<PetModel>
                       {
                new PetModel()
                {
                    Name = "Garfield",
                    Weight = 20.00,
                    Classification = PetClassification.Mammal,
                    Type = PetType.Cat,
                },
                new PetModel()
                {
                    Name = "Odie",
                    Weight = 15.00,
                    Classification = PetClassification.Mammal,
                    Type = PetType.Dog,
                },
                new PetModel()
                {
                    Name = "Peter Parker",
                    Weight = 0.50,
                    Classification = PetClassification.Arachnid,
                    Type = PetType.Spider,
                },
                new PetModel()
                {
                    Name = "Kaa",
                    Weight = 25.00,
                    Classification = PetClassification.Reptile,
                    Type = PetType.Snake,
                },
                new PetModel()
                {
                    Name = "Nemo",
                    Weight = 0.50,
                    Classification = PetClassification.Fish,
                    Type = PetType.Goldfish,
                },
                new PetModel()
                {
                    Name = "Alpha",
                    Weight = 0.10,
                    Classification = PetClassification.Fish,
                    Type = PetType.Betta,
                },
                new PetModel()
                {
                    Name = "Splinter",
                    Weight = 0.50,
                    Classification = PetClassification.Mammal,
                    Type = PetType.Rat,
                },
                new PetModel()
                {
                    Name = "Coco",
                    Weight = 06.00,
                    Classification = PetClassification.Bird,
                    Type = PetType.Parrot,
                },
                new PetModel()
                {
                    Name = "Tweety",
                    Weight = 0.05,
                    Classification = PetClassification.Bird,
                    Type = PetType.Canary,
                }
                        };
            foreach (PetModel pet in Pets)
            {
                pet.Size = WeightWork.weightWork(pet.Weight);

            }

            return (People, Pets);
        }
    }
}
            
