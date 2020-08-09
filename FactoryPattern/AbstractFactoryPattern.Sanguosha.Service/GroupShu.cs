using AbstractFactoryPattern.Sanguosha.Interface;
using System;

namespace AbstractFactoryPattern.Sanguosha.Service
{
    public class GroupShu : IGroup
    {
        public void ShowGroup()
        {
            Console.WriteLine("{0} is 刘备", this.GetType().Name);
        }
    }
}