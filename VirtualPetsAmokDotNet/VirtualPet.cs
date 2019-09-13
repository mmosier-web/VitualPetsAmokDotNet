using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmokDotNet
{
    public class VirtualPet
    {
        public int Hunger { get; set; }
        public int PetSocial { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }


        public VirtualPet()
        {
            Hunger = 10;
            PetSocial = 10;
            Health = 10;

        }
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("If you want to see your pets info enter: PetsInfo");
            Console.WriteLine("If you want to see your pets status enter: PS ");
            Console.WriteLine("If you want to feed your pet enter: Feed");
            Console.WriteLine("If you want to play with your pet enter: Play");
            Console.WriteLine("If you want to take you pet to the doctor enter: Doctor");

        }
        public void PetName()
        {
            Console.WriteLine("What is its Name: ");
            Name = Console.ReadLine();
        }
        public void PetSpecies()
        {
            Console.WriteLine("What species is it: ");
            Species = Console.ReadLine();
        }

        public void PetInfo()
        {
            Console.WriteLine("Your pets name is :" + " " + Name);
            Console.WriteLine("Your pets species is :" + " " + Species);
        }
        public void PetStatus()
        {
            Console.WriteLine("Hunger (Dont let the number reach 0 or less or you pet will lose health) social (If you pet gets to lonely it will lose health) Health (If health = 0 your pet will die so mke sure to go to the doctor)");
            Console.WriteLine("Pet hunger = " + Hunger + " Social = " + PetSocial + " Health = " + Health);
        }
        public void Feed()
        {
            Console.WriteLine("You have fed your pet!");
            Hunger -=2;

            PetSocial--;
            if (Hunger <= 0)
            {
                Console.WriteLine("Your pet is to low on food and is losing health!");
                Health--;
            }
        }
        public void Play()
        {
            if (Health == 3)
            {
                Console.WriteLine("You must go to doctor before playing with you pet because it's health is to low!");
                if (Hunger <= 0)
                {
                    Console.WriteLine("Your pet is to low on food and is losing health!");
                    Health--;
                }

            }
            else
            {
                Console.WriteLine("You played with your pets");
                PetSocial++;
                Hunger--;
                Hunger--;
                Random rnd = new Random();
                int HealthDown = rnd.Next(1, 5);
                switch (HealthDown)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        Health--;
                        Console.WriteLine("Your pet got hurt while playing!");
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
                if (Hunger <= 0)
                {
                    Console.WriteLine("Your pet is to low on food and is losing health!");
                    Health--;
                }

            }
        }
        public void Doctor()
        {
            Console.WriteLine("You took your pet to the doctor!");
            Health++;
            Health++;
            Hunger--;
            PetSocial--;
            if (Hunger <= 0)
            {
                Console.WriteLine("Your pet is to low on food and is losing health!");
                Health--;
            }

        }
    }
}
