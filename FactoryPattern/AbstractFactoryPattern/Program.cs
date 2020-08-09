using AbstractFactoryPattern.Sanguosha.Interface;
using System;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            {
                AbstractFactory factory = new FactoryShu();

                IGroup group = factory.CreateGroup();// new GroupShu();
                IGenerals generals = factory.CreateGenerals();// new GeneralsShu();
                group.ShowGroup();
                generals.ShowGenerals();
            }

            Console.WriteLine("*********************************************");

            {
                AbstractFactory factory = new FactoryWei();

                IGroup group = factory.CreateGroup();
                IGenerals generals = factory.CreateGenerals();
                group.ShowGroup();
                generals.ShowGenerals();
            }

            Console.WriteLine("*********************************************");

            {
                AbstractFactory factory = new FactoryWu();

                IGroup group = factory.CreateGroup();
                IGenerals generals = factory.CreateGenerals();
                group.ShowGroup();
                generals.ShowGenerals();
            }

            Console.Read();
        }
    }
}