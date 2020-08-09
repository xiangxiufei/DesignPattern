using FactoryPattern.War3.Interface;
using FactoryPattern.War3.Service;
using System;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 1 对比简单工厂，建立工厂方法(FactoryMethod)
    /// 2 工厂方法的优缺点和应用
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                {
                    Human human = new Human();
                    Undead undead = new Undead();
                    NE ne = new NE();
                    ORC orc = new ORC();

                    //Six six=new Six()//参数信息很麻烦
                }

                {
                    IRace human = new Human();
                    IRace undead = new Undead();
                    IRace ne = new NE();
                    IRace orc = new ORC();
                }

                {
                    IFactory humanFactory = new HumanFactory();
                    IRace human = humanFactory.CreateInstance();

                    IFactory fiveFactory = new FiveFactory();
                    IRace five = fiveFactory.CreateInstance();

                    IFactory sixFactory = new SixFactoryExtend();// new SixFactory();

                    IRace six = sixFactory.CreateInstance();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}