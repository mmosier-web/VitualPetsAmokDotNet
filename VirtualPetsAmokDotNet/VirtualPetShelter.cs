using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmokDotNet
{
    class VirtualPetShelter
    {
        List<VirtualPet> shelter = new List<VirtualPet>();

        public VirtualPetShelter()
        {

        }
        public void AddPetToShelter(VirtualPet pet)
        {
            shelter.Add(pet);
        }
    }
}
