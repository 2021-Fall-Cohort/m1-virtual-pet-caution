using System;
using System.Collections.Generic;
using Xunit;

namespace VirtualPet.Tests
{
    public class Shelter1Test
    {
        private Shelter shelter;

        public  Shelter1Test()
        { shelter = new Shelter();     }


        [Fact]
        public void AddPet_Should_Increase_List_Size_By_1()
        {
            shelter.AddPet(new Pet());


            Assert.Single(shelter.ListOfPets);
        }





    }
}
