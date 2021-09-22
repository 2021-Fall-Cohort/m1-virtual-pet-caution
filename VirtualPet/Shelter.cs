using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
   public  class Shelter
    {
        public List<Pet> ListOfPets = new List<Pet>();
        public string Name { get; set; }

        public void AddPet(Pet pet1)
        {
            ListOfPets.Add(pet1);
        }


        public void ListPets()
        {
            int index = 1;

            foreach (Pet pet1 in ListOfPets)
            {
                Console.WriteLine($"{index}: {pet1.GetName()}, {pet1.GetSpecies()}");
                index++;
            }
        }
        public Pet PickAPet()
        {
            Console.Clear();

            Console.WriteLine("Please pick a pet from the list:  ");
            int index = 1;

            foreach (Pet pet1 in ListOfPets)
            {
                Console.WriteLine($"{index}: {pet1.GetName()}, {pet1.GetSpecies()}");
                index++;
            }

            int indexSelected = Convert.ToInt32(Console.ReadLine());

            return ListOfPets[indexSelected - 1];
           
        }

        public void Adopt(Pet pet1)
        {
            ListOfPets.Remove(pet1);
        }

      public void CheckAllStats()
        {
            int index = 1;
            foreach (Pet pet1 in ListOfPets)
            {
                Console.WriteLine($"{index}: {pet1.GetName()}, {pet1.GetSpecies()}");
                pet1.CheckStatus();
                index++;
            }
        }

       public void InteractWithAll()
        {
            bool keepThinking = true;
            while (keepThinking == true)
            {
                Console.WriteLine("Choose an action!");
                Console.WriteLine("1. Feed all pets.");
                Console.WriteLine("2. Play with all pets.");
                Console.WriteLine("3. Heal all pets.");
                Console.WriteLine("Press Q to return to main menu.");
                string UserInput = Console.ReadLine().ToLower();

                int index = 1;

                switch (UserInput)
                {
                    case "1":
                        foreach (Pet pet1 in ListOfPets)
                        {
                            Console.WriteLine($"{index}: {pet1.GetName()}, {pet1.GetSpecies()}");
                            pet1.Feed();
                            index++;
                        }
                        break;
                    case "2":
                        foreach (Pet pet1 in ListOfPets)
                        {
                            Console.WriteLine($"{index}: {pet1.GetName()}, {pet1.GetSpecies()}");
                            pet1.Play();
                            index++;
                        }
                        break;
                    case "3":
                        foreach (Pet pet1 in ListOfPets)
                        {
                            Console.WriteLine($"{index}: {pet1.GetName()}, {pet1.GetSpecies()}");
                            pet1.SeeDoctor();
                            index++;
                        }
                        break;
                    case "q":
                        keepThinking = false;
                        break;
                    default:
                        break;
                }

            }
           
        }


    } 


}
