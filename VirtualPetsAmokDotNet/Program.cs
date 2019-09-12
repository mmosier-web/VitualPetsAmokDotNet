using System;

namespace VirtualPetsAmokDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet pet = new VirtualPet();
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
            Console.WriteLine("What is its Name: ");
            pet.PetName();
            Console.WriteLine("What species is it: ");
            pet.PetSpecies();
            Console.Clear();

            bool mainMenu = true;
            while (mainMenu)
            {
                Console.Clear();
                Console.WriteLine("MAIN MENU");
                Console.WriteLine("If you want to see your pets info enter: PetsInfo");
                Console.WriteLine("If you want to see your pets status enter: PS ");
                Console.WriteLine("If you want to feed your pet enter: Feed");
                Console.WriteLine("If you want to play with your pet enter: Play");
                Console.WriteLine("If you want to take you pet to the doctor enter: Doctor");
                if (pet.Health == 0)
                {
                    Console.WriteLine("You have let your pet's health get to low and it has died");
                    Console.WriteLine("Game Over");
                    Environment.Exit(0);
                    Console.ReadKey();
                }

                string playerSelection = Console.ReadLine().ToLower();
                if (playerSelection == "petsinfo")
                {
                    pet.PetInfo();
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();
                }
                if (playerSelection == "ps")
                {
                    pet.PetStatus();
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();
                }
                if (playerSelection == "feed")
                {
                    pet.Feed();
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();
                }
                if (playerSelection == "play")
                {
                    pet.Play();
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();
                }
                if (playerSelection == "doctor")
                {
                    pet.Doctor();
                    Console.WriteLine("Press Enter");
                    Console.ReadKey();
                }
            }
        }
    }
}
