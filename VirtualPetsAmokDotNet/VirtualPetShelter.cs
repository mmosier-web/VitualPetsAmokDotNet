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
        public void ShowAllInfo()
        {
            foreach(VirtualPet pet in shelter)
            {
                pet.PetInfo();
            }
        }
        public void ShowAllStatus()
        {
            foreach(VirtualPet pet in shelter)
            {
                pet.PetStatus();
            }
        }
        public void FeedAllPets()
        {
            foreach (VirtualPet pet in shelter)
            {
                pet.Feed();
            }
        }
        public void PlayAll()
        {
            foreach (VirtualPet pet in shelter)
            {
                pet.Play();
            }
        }
        public void TakeAllToDoctor()
        {
            foreach (VirtualPet pet in shelter)
            {
                pet.Doctor();
            }
        }
    }
}
