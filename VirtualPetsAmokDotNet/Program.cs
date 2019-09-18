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
               
            }
        }
    }
}
