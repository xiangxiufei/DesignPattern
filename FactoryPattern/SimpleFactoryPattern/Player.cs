using FactoryPattern.War3.Interface;
using FactoryPattern.War3.Service;
using System;

namespace SimpleFactoryPattern
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void PlayHuman(Human war3)
        {
            Console.WriteLine("{0} play wa3", this.Name);
            war3.ShowKing();
        }

        public void PlayUndead(Undead war3)
        {
            Console.WriteLine("{0} play wa3", this.Name);
            war3.ShowKing();
        }

        public void PlayWar3(IRace war3)
        {
            Console.WriteLine("{0} play wa3", this.Name);
            war3.ShowKing();
        }
    }
}