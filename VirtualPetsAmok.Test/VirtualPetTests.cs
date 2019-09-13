using System;
using Xunit;

namespace VirtualPetsAmokDotNet.Test
{
    public class VirtualPetTests
    {
        [Fact]
        public void Feed_Decreases_Hunger_By_2()
        {
            VirtualPet pet = new VirtualPet();
            pet.Hunger = 10;

            pet.Feed();

            Assert.Equal(8, pet.Hunger);

        }
    }
}
