using AbstractFactoryPattern.Sanguosha.Interface;
using System;

namespace AbstractFactoryPattern.Sanguosha.Service
{
    public class GeneralsWu : IGenerals
    {
        public void ShowGenerals()
        {
            Console.WriteLine("{0}:黄盖，甘宁，太史慈，韩当，凌统", this.GetType().Name);
        }
    }
}