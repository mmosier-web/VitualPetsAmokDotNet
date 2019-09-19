using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmokDotNet
{
    class Menu
    {
        VirtualPetShelter shelter = new VirtualPetShelter();

        public Menu() 
        {
           
        }

        public void MainMenu() 
        {
            VirtualPet pet = new VirtualPet();

            Console.Clear();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine(" ");
            Console.WriteLine("Create a pet: Press 1");
            Console.WriteLine("View pet info: Press 2");
            Console.WriteLine("View pet status: Press 3");
            Console.WriteLine("Feed/oil pet: Press 4");
            Console.WriteLine("Play with pet: Press 5");
            Console.WriteLine("Take pet for doctor/mechanic visit: Press 6");
            Console.WriteLine("End Game: Press 7");

            string playerSelection = Console.ReadLine().ToLower();
            if (playerSelection == "1")
            {
                Console.WriteLine("If you want to make an organic pet: press 1");
                Console.WriteLine("If you want to make an robotic pet: press 2");
                string OrganicOrRobotic = Console.ReadLine();
                if (OrganicOrRobotic == "1")
                {
                    pet = new OrganicPet();
                    pet.PetName();
                    pet.PetSpecies();
                    shelter.AddPetToShelter(pet);
                }
                else if (OrganicOrRobotic == "2")
                {
                    pet = new RoboticPet();
                    pet.PetName();
                    pet.PetSpecies();
                    shelter.AddPetToShelter(pet);
                }

            }
            else if (playerSelection == "2")
            {
                //pet.PetInfo();
                shelter.ShowAllInfo();
                Console.WriteLine("Press Enter");
                Console.ReadKey();
            }
            else if (playerSelection == "3")
            {
                shelter.ShowAllStatus();
                Console.WriteLine("Press Enter");
                Console.ReadKey();
            }
            else if (playerSelection == "4")
            {
                pet.Feed();
                Console.WriteLine("Press Enter");
                Console.ReadKey();
            }
            else if (playerSelection == "5")
            {
                pet.Play();
                Console.WriteLine("Press Enter");
                Console.ReadKey();
            }
            else if (playerSelection == "6")
            {
                pet.Doctor();
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
