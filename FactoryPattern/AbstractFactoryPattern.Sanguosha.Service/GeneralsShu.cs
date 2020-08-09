using AbstractFactoryPattern.Sanguosha.Interface;
using System;

namespace AbstractFactoryPattern.Sanguosha.Service
{
    public class GeneralsShu : IGenerals
    {
        public void ShowGenerals()
        {
            Console.WriteLine("{0}:关羽，张飞，赵云，马超，黄忠", this.GetType().Name);
        }
    }
}