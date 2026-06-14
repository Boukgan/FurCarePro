using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurCarePro.AbstractClasses
{
    public abstract class Animal
    {
        public int PetID { get; set; }

        public string PetName { get; set; }

        public abstract string GetPetType();

        public virtual string GetAnimalType()
        {
            return "Animal";
        }
    }

}
