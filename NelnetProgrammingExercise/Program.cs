using NelnetProgrammingExercise.Models;
using NelnetProgrammingExercise.Work;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace NelnetProgrammingExercise
{
    public class Program
    {
        public static PersonModel[] People;
        public static PetModel[] Pets;

        static void Main(string[] args)
        {
            SetupWork.SetupObjects();
            MatchingWork.MatchWork();
        }
    }
}
