using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmokDotNet
{
  public class RoboticPet: VirtualPet
    {
        public int OilLevel { get; set; }
        public int PetSocialRobotic { get; set; }
        public int Maintenance { get; set; }

        public void PetNameOrganic()
        {
            Console.WriteLine("What is its Name: ");
            Name = Console.ReadLine();
            void PetSpeciesOrganic()
            {
                Console.WriteLine("What species is it: ");
                Species = Console.ReadLine();
            }

        }
        public void PetInfoOrganic()
        {
            Console.WriteLine("Your pets name is :" + " " + Name);
            Console.WriteLine("Your pets species is :" + " " + Species);
        }

        public RoboticPet()
        {
            OilLevels = 10;
            PetSocialRobotic = 10;
            Maintenance = 10;

        }

        public void PetStatusRobotic()
        {
            Console.WriteLine(Name + " " + Species);
            Console.WriteLine("Hunger (Dont let the number reach 0 or less or you pet will lose health) social (If you pet gets to lonely it will lose health) Health (If health = 0 your pet will die so mke sure to go to the doctor)");
            Console.WriteLine("Pet Fullness = " + Fullness + " Social = " + PetSocial + " Health = " + Health);
        }

        public void FeedOrganic()
        {
            Console.WriteLine("You have fed your pet!");
            Fullness += 2;

            PetSocial--;
            if (Fullness <= 0)
            {
                Console.WriteLine("Your pet is to low on food and is losing health!");
                Health--;
            }
        }
        public void PlayOrganic()
        {
            if (Health == 3)
            {
                Console.WriteLine("You must go to doctor before playing with you pet because it's health is to low!");
                if (Fullness <= 0)
                {
                    Console.WriteLine("Your pet is to low on food and is losing health!");
                    Health--;
                }

            }
            else
            {
                Console.WriteLine("You played with your pet");
                PetSocial++;
                Fullness--;
                Fullness--;
                Random rnd = new Random();
                int HealthDown = rnd.Next(1, 6);
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
                if (Fullness <= 0)
                {
                    Console.WriteLine("Your pet is to low on food and is losing health!");
                    Health--;
                }

            }
        }
        public void DoctorOrganic()
        {
            Console.WriteLine("You took your pet to the doctor!");
            Health++;
            Health++;
            Fullness--;
            PetSocial--;
            if (Fullness <= 0)
            {
                Console.WriteLine("Your pet is to low on food and is losing health!");
                Health--;
            }

        }
        

    }
}