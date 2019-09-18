using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmokDotNet
{
    class Menu
    {
        public Menu() 
        {
           
        }

        public void MenuOrganic() 
           {
            VirtualPetShelter shelter = new VirtualPetShelter();
            OrganicPet OrganicPet = new OrganicPet();
            Console.Clear();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine(" ");
            Console.WriteLine("Create a pet: Press 1");
            Console.WriteLine("View pet info: Press 2");
            Console.WriteLine("View pet status: Press 3");
            Console.WriteLine("Feed pet: Press 4");
            Console.WriteLine("Play with pet: Press 5");
            Console.WriteLine("Take pet for doctor visit: Press 6");
            Console.WriteLine("End Game: Press 7");

            string playerSelection = Console.ReadLine().ToLower();
            if (playerSelection == "1")
            {
                OrganicPet = new OrganicPet();
                OrganicPet.PetName();
                OrganicPet.PetSpecies();
                shelter.AddPetToShelter(OrganicPet);
            }
            else if (playerSelection == "2")
            {
                //pet.PetInfo();
                OrganicPet.PetInfo();
                Console.WriteLine("Press Enter");
                Console.ReadKey();
            }
            else if (playerSelection == "3")
            {
                OrganicPet.PetStatus();
                Console.WriteLine("Press Enter");
                Console.ReadKey();
            }
            else if (playerSelection == "4")
            {
                OrganicPet.Feed();
                Console.WriteLine("Press Enter");
                Console.ReadKey();
            }
            else if (playerSelection == "5")
            {
                OrganicPet.Play();
                Console.WriteLine("Press Enter");
                Console.ReadKey();
            }
            else if (playerSelection == "6")
            {
                OrganicPet.Doctor();
                Console.WriteLine("Press Enter");
                Console.ReadKey();
            }
            else if (playerSelection == "7")
            {
                Environment.Exit(0);
            }
        }
    }
}
