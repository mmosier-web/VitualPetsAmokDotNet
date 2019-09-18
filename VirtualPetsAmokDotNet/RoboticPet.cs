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

        public RoboticPet()
        {
            OilLevel = 10;
            PetSocialRobotic = 10;
            Maintenance = 10;

        }

        public override void PetName()
        {
            Console.WriteLine("What is its Name: ");
            Name = Console.ReadLine();
        }
      public override void PetSpecies()
        {
            Console.WriteLine("What species is it: ");
            Species = Console.ReadLine();
        }
        public override void PetInfo()
        {
            Console.WriteLine("Your pets name is :" + " " + Name);
            Console.WriteLine("Your pets species is :" + " " + Species);
        }
        
        public override void PetStatus()
        {
            Console.WriteLine(Name + " " + Species);
            Console.WriteLine("Hunger (Dont let the number reach 0 or less or you pet will lose health) social (If you pet gets to lonely it will lose health) Health (If health = 0 your pet will die so mke sure to go to the doctor)");
            Console.WriteLine("Pet oilLevel = " + OilLevel + " Social = " + PetSocialRobotic + " Maintenance = " + Maintenance);
        }
        public override void Feed()
        {
            Console.WriteLine("You have oiled your pet!");
            OilLevel += 2;

            PetSocialRobotic--;
            if (OilLevel <= 0)
            {
                Console.WriteLine("Your pet is to low on oil and will need maintenance!");
                Maintenance--;
            }
        }
        public override void Play()
        {
            if (Maintenance == 3)
            {
                Console.WriteLine("You must oil before playing with you pet because it needs oil");
                if (OilLevel <= 0)
                {
                    Console.WriteLine("Your pet is to low on oil and it needs maintenance!");
                    Maintenance--;
                }

            }
            else
            {
                Console.WriteLine("You played with your pet");
                PetSocialRobotic++;
                OilLevel--;
                OilLevel--;
                Random rnd = new Random();
                int HealthDown = rnd.Next(1, 6);
                switch (HealthDown)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        Maintenance--;
                        Console.WriteLine("Your pet got hurt while playing!");
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
                if (OilLevel <= 0)
                {
                    Console.WriteLine("Your pet is to low on oil and needs maintenance!");
                    Maintenance--;
                }

            }
        }
        public override void Doctor()
        {
            Console.WriteLine("You took your pet to the mechanic!");
            Maintenance++;
            Maintenance++;
            OilLevel--;
            PetSocialRobotic--;
            if (OilLevel <= 0)
            {
                Console.WriteLine("Your pet is to low on oil and needs oiled");
                OilLevel--;
            }
        }
    }
}