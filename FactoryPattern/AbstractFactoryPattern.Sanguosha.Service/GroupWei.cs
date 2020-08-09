using AbstractFactoryPattern.Sanguosha.Interface;
using System;

namespace AbstractFactoryPattern.Sanguosha.Service
{
    public class GroupWei : IGroup
    {
        public void ShowGroup()
        {
            Console.WriteLine("{0} is 曹操", this.GetType().Name);
        }
    }
}