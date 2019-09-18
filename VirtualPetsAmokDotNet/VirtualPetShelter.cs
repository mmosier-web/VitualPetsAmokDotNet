using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmokDotNet
{
    class VirtualPetShelter
    {
        List<OrganicPet> shelter = new List<OrganicPet>();

        public VirtualPetShelter()
        {

        }
        public void AddPetToShelter(OrganicPet pet)
        {
            shelter.Add(pet);
        }
        public void ShowAllInfo()
        {
            foreach(OrganicPet pet in shelter)
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
            foreach (OrganicPet pet in shelter)
            {
                pet.Feed();
            }
        }
        public void PlayAll()
        {
            foreach (OrganicPet pet in shelter)
            {
                pet.Play();
            }
        }
        public void TakeAllToDoctor()
        {
            foreach (OrganicPet pet in shelter)
            {
                pet.Doctor();
            }
        }
    }
}
