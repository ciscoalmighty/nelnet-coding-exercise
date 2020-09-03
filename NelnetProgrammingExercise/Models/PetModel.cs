using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace NelnetProgrammingExercise.Models
{

    public class PetModel
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public PetClassification Classification { get; set; }
        public PetType Type { get; set; }
        public PetSize Size { get; set; }
     
    }
}
