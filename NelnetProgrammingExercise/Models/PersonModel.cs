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
        public virtual PetSize PreferredPetSize { get; set; }

    }
}
