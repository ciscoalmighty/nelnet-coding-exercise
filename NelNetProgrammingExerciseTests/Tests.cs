using Microsoft.VisualStudio.TestTools.UnitTesting;
using NelnetProgrammingExercise;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using NelnetProgrammingExercise.Models;
using System.Linq;
using System.Reflection;


namespace NelNetProgrammingExerciseTests
{
    [TestClass]
    public class Tests
    {
        [ExcludeFromCodeCoverage]
        [TestMethod]
        public void PetValuesTest()
        {
            // Act
            var objects = Program.Pets;

            //Assert
            Assert.AreEqual(9, objects.Length);
            Assert.AreEqual("Garfield", objects[0].Name);
        }

        [TestMethod]
        public void PeopleValuesTest()
        {
            // Act
            var objects = Program.People;

            //Assert
            Assert.AreEqual(2, objects.Length);
            Assert.AreEqual("Dalinar", objects[0].Name);
        }

        [TestMethod]
        public void PetWeightForPeterParker()
        {
            // Act
            var objects = Program.Pets;
            var PeterParkerWeight = objects.Single(p => p.Name == "Peter Parker").Weight;

            // Assert
            Assert.AreEqual(0.50, PeterParkerWeight);
        }

        [TestMethod]
        public void KaladinTest()
        {
            // Act
            var objects = Program.People;
            var KaladinPetSize = objects.Single(p => p.Name == "Kaladin").PetSize;

            // Assert
            Assert.AreEqual(PetSize.ExtraSmall, KaladinPetSize);
        }


    }
}