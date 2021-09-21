using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{


    public class Pet
    {
        public Pet(string name, string species)
        {
            this.Name = name;
            this.Species = species;
            this.Health = 60;
            this.Hunger = 60;
            this.Boredom = 20;
        
        }
        public Pet() { }

        public string Name { set; get; }
        public string Species { set; get; }
        public int Hunger { set; get; }
        public int Boredom { set; get; }

        public int Health { set; get; }


        public void SetName(string name) { this.Name = name; }
        public string GetName() { return this.Name; }

        public void SetSpecies(string sp) { this.Species = sp; }
        public string GetSpecies() { return this.Species; }
        public int GetHunger() { return this.Hunger; }

        public int GetBoredom() {  return this.Boredom; }
            
        public int GetHealth()
        {
            return this.Health;
        }
      
        public virtual void Feed() {

          //  Console.WriteLine(this.Hunger);
            this.Hunger -=40;
          //  Console.WriteLine(this.Hunger);
        }

        public void SeeDoctor() {

          //  Console.WriteLine(this.Health);
            this.Health += 30;
           // Console.WriteLine(this.Health);
        
        }
        
        public void Play() {  this.Hunger+= 10; this.Health -= 15; }


        public virtual void Tick()
        {
            if ((this.Boredom += 5) > 100)
            {
                this.Boredom = 100;
            }
            else
            {
                this.Boredom += 5;
            }

            if ((this.Health -= 5) < 0)
            {
                this.Health = 0;
            }
            else
            {
                this.Health -= 5;
            }

            if ((this.Hunger += 5) > 100)
            {
                this.Hunger = 100;
            }
            else
            {
                this.Health += 5;
            }
            // will prevent amounts going over 100 or into negatives; caps them off by setting a "max/min"
            //Console.WriteLine( Boredom);
            //Console.WriteLine(Hunger);
            //Console.WriteLine()
            // Console.WriteLine("Pet Status: Boredom  {0}  Hunger  {1}  Health  {2} ", this.Boredom, this.Hunger, this.Health);
        }


        public virtual void CheckStatus()
        { Console.WriteLine(" helth "+this.Health+" hunger "+ this.Hunger+ "  bordem "+this.Boredom);
          //  Console.ReadLine();
        }



      
    }
}