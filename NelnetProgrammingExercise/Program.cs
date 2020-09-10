using NelnetProgrammingExercise.Models;
using NelnetProgrammingExercise.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace NelnetProgrammingExercise
{
    public class Program
    {

        static void Main(string[] args)
        {
            var setUp = SetupWork.SetUpLists();
            var People = setUp.People;
            var Pets = setUp.Pets;
            MatchingWork.MatchWork(People, Pets);

        }


    }
}