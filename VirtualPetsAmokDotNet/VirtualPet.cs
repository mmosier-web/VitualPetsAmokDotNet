using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmokDotNet
{
    public class VirtualPet
    {
        
        public string Name { get; set; }
        public string Species { get; set; }

        public void PetName()
        {
            Console.WriteLine("What is its Name: ");
            Name = Console.ReadLine();
        }
        public void PetSpecies()
        {
            Console.WriteLine("What species is it: ");
            Species = Console.ReadLine();
        }

        public void PetInfo()
        {
            Console.WriteLine("Your pets name is :" + " " + Name);
            Console.WriteLine("Your pets species is :" + " " + Species);
        }
    }
}
