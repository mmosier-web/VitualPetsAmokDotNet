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
            Console.WriteLine("To have a pet be adopted: press 7");
            Console.WriteLine("End Game: Press 8");

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
                Console.WriteLine("If you want to feed/oil all pets press: 1");
                Console.WriteLine("If you want to feed one pet press: 2");
                string FeedAllOr1 = Console.ReadLine();
                if (FeedAllOr1 == "1")
                {
                    shelter.FeedAllPets();
                }
                else if (FeedAllOr1 == "2")
                {
                    shelter.ShowAllInfo();
                    shelter.FeedSinglePet();


                }
                //pet.Feed();
                //Console.WriteLine("Press Enter");
                //Console.ReadKey();
            }
            else if (playerSelection == "5")
            {
                Console.WriteLine("If you want to play all pets press: 1");
                Console.WriteLine("If you want to play with one pet press: 2");
                string PlayAllOr1 = Console.ReadLine();
                if (PlayAllOr1 == "1")
                {
                    shelter.FeedAllPets();
                }
                else if (PlayAllOr1 == "2")
                {
                    shelter.ShowAllInfo();
                    shelter.playSinglePet();
                }
            }
            else if (playerSelection == "6")
            {
                Console.WriteLine("If you want to take all pets to doctor/mechanic press: 1");
                Console.WriteLine("If you want to take one pet to doctor/mechanic press: 2");
                string DMAllOr1 = Console.ReadLine();
                if (DMAllOr1 == "1")
                {
                    shelter.FeedAllPets();
                }
                else if (DMAllOr1 == "2")
                {
                    shelter.ShowAllInfo();
                    shelter.DMSinglePet();
                }
            }
            else if (playerSelection == "7")
            {
                shelter.ShowAllInfo();
                shelter.AdoptedPet();
            }
            else if (playerSelection == "8")
            {
                Environment.Exit(0);
            }
        }
    }
}
