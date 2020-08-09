using AbstractFactoryPattern.Sanguosha.Interface;
using System;

namespace AbstractFactoryPattern.Sanguosha.Service
{
    public class GeneralsWei : IGenerals
    {
        public void ShowGenerals()
        {
            Console.WriteLine("{0}:许诸，典韦，夏侯渊，徐晃，张辽", this.GetType().Name);
        }
    }
}