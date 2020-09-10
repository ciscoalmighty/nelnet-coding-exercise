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

        public PetModel() { }

        public PetModel(string name, double weight, PetClassification petclass, PetType pettype, PetSize petsize)
        {
            Name = name;
            Weight = weight;
            Classification = petclass;
            Type = pettype;
            Size = petsize;

        }


     
    }
}
