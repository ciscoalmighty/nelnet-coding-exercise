using Microsoft.VisualStudio.TestTools.UnitTesting;
using NelnetProgrammingExercise;
using NelnetProgrammingExercise.Models;
using NelnetProgrammingExercise.Work;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        PersonModel testPerson;
        PetModel testPet;
        List<PersonModel> testPersonList = new List<PersonModel>();
        List<PetModel> testPetList = new List<PetModel>();

        [TestInitialize]
        public void Initialize()
        {
            testPerson = new PersonModel("Jake", PetClassification.Mammal,
                    PetType.Snake,
                    PetSize.Medium);

            testPet = new PetModel("Tank",
                20.00,
                PetClassification.Mammal,
                PetType.Cat,
                PetSize.Large);

            testPetList.Add(testPet);
            testPersonList.Add(testPerson);

        }

        [TestMethod]
        public void PetTest()
        {
            //
            var result = testPet.Name;
           //Assert
            Assert.AreEqual("Tank", result);
            Assert.AreEqual(20.00, testPet.Weight); 
        }

        [TestMethod]
        public void PeopleValuesTest()
        {       
            //Assert
            Assert.AreEqual("Jake", testPerson.Name);        
        }

        [TestMethod]
        public void TestPetListWeightTest()
        {
            // Act
            var TankWeight = testPetList.Single(p => p.Name == "Tank").Weight;
            // Assert
            Assert.AreEqual(20.00, TankWeight); 
        }

        [TestMethod]
        public void TestPersonListTest()
        { 
            // Act
            var JakePetSize = testPersonList.Single(p => p.Name == "Jake").PetSize;
            // Assert
            Assert.AreEqual("Medium", JakePetSize.ToString());
        }

    }
}
