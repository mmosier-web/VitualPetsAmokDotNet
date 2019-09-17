using System;
using System.Collections.Generic;

namespace VirtualPetsAmokDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            RoboticPet Robotic = new RoboticPet();
            OrganicPet Organic = new OrganicPet();
            VirtualPet pet = new VirtualPet();
            VirtualPetShelter shelter = new VirtualPetShelter();
            Console.WriteLine("Would you like to start the Game? (Y / N)");
            string Player = Console.ReadLine().ToLower();

            bool StartGame = true;
            while (StartGame)
            {
                if (Player == "yes" || Player == "y")
                {
                    StartGame = false;
                }
                else
                {
                    StartGame = true;
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Welcome to Virtual Pets! In this game you can create any pet you can think of and take care of it! Have Fun!");

            //pet.PetName();
            //pet.PetSpecies();


            Console.Clear();

            bool mainMenu = true;
            while (mainMenu)
            {
                pet.MainMenu();
                if (pet.Health == 0)
                {
                    Console.WriteLine("You have let your pet's health get too low and it has died");
                    Console.WriteLine("Game Over");
                    Environment.Exit(0);
                    Console.ReadKey();
                }

                string playerSelection = Console.ReadLine().ToLower();
                if (playerSelection == "add")
                {
                    pet = new VirtualPet();
                    pet.PetName();
                    pet.PetSpecies();
                    shelter.AddPetToShelter(pet);
                }

                else if (playerSelection == "petsinfo")
                {
                    //pet.PetInfo();
                    shelter.ShowAllInfo();
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();
                }
                else if (playerSelection == "ps")
                {
                    pet.PetStatus();
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();
                }
                else if (playerSelection == "feed")
                {
                    pet.Feed();
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();
                }
                else if (playerSelection == "play")
                {
                    pet.Play();
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();
                }
                else if (playerSelection == "doctor")
                {
                    Organic.DoctorOrganic();
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();
                }
                else if (playerSelection == "allstatus")
                {
                    shelter.ShowAllStatus();
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();
                }
                else if (playerSelection == "feedall")
                {
                    shelter.FeedAllPets();
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();
                }
                else if (playerSelection== "playall")
                {
                    shelter.PlayAll();
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();
                }
                else if (playerSelection == "doctorall")
                {
                    shelter.TakeAllToDoctor();
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();
                }
                else if (playerSelection == "exit") 
                {
                    Environment.Exit(0);

                }
                
            }
        }
    }
}
