using AbstractFactoryPattern.Sanguosha.Interface;
using System;

namespace AbstractFactoryPattern.Sanguosha.Service
{
    public class GroupWu : IGroup
    {
        public void ShowGroup()
        {
            Console.WriteLine("{0} is 孙权", this.GetType().Name);
        }
    }
}