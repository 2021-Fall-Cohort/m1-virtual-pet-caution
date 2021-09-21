using System;

namespace VirtualPet
{
    class Ironper : Pet
    {
        //public int chargLevel;

        public bool chargingMode;
        public void HookupCharher() { this.chargingMode = true; }
        public void UnHookCharher() { this.chargingMode = false; }

        public void Charging()
        {
            if (chargingMode) this.Health += 10;
            else this.Health -= 1;
        }

        public override void Tick() { Charging();}
      //  public override void TickI() { this.Charging(this.chargingMode); }
       // public void CheckStatusI() { base.CheckStatus(); Console.WriteLine( "Charghing mode is "+ chargingMode); }

        public void Play() { chargingMode = false; base.Health -= 20; }
        public override void Feed() { HookupCharher(); Tick(); }

        public override void CheckStatus()
        {
            Console.WriteLine(" helth " + this.Health + " hunger " + this.Hunger + "  bordem " + this.Boredom+"    "+ this.chargingMode+  " override wersion");
            // Console.WriteLine();
        }



    }
}
