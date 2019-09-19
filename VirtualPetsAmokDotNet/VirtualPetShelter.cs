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
            int Id = 1;
            foreach (VirtualPet pet in shelter)
            {
                Console.Write("ID " + Id + " ");
                pet.PetInfo();
                Id++;
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
        public void FeedSinglePet()
        {
            Console.WriteLine("Pick a Pet to feed by its self by entering its ID number");
            VirtualPet pet = shelter[Convert.ToInt32(Console.ReadLine()) - 1];
            pet.Feed();
        }
        public void playSinglePet()
        {
            Console.WriteLine("Pick a Pet to play by its self by entering its ID number");
            VirtualPet pet = shelter[Convert.ToInt32(Console.ReadLine()) - 1];
            pet.Play();
        }
        public void DMSinglePet()
        {
            Console.WriteLine("Pick a Pet to take to the doctor/mechanic by its self by entering its ID number");
            VirtualPet pet = shelter[Convert.ToInt32(Console.ReadLine()) - 1];
            pet.Doctor();
        }
        public void AdoptedPet()
        {
            Console.WriteLine("Pick a Pet to be adopted by entering its ID number");
            VirtualPet pet = shelter[Convert.ToInt32(Console.ReadLine()) - 1];
            shelter.Remove(pet);
        }
    }
}
