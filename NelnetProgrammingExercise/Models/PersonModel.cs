using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;


namespace NelnetProgrammingExercise.Models
{
    public class PersonModel 
    {
        public string Name { get; set; }
        public virtual PetClassification PreferredClassification { get; set; }
        public virtual PetType PreferredPetType { get; set; }
        public virtual PetSize PetSize { get; set; }

        public PersonModel()
        {
        }

        public PersonModel(string name, PetClassification petclass, PetType pettype, PetSize petsize)
        {
            Name = name;
            PreferredClassification = petclass;
            PreferredPetType = pettype;
            PetSize = petsize;
        }



    }
}
