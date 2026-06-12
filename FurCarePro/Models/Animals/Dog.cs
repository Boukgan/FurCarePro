using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurCarePro.AbstractClasses;

namespace FurCarePro.Models.Animals
{
    public class Dog : Animal
    {
        public override string GetPetType()
        {
            return "Dog";
        }
    }
}