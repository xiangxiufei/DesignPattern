using System;

namespace BuilderPattern
{
    /// <summary>
    /// 1 Builder设计模式4大角色
    /// 2 和工厂模式的区别
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("**********************************");
                {
                    AbstractBuilder builder = new BuilderFord();
                    builder.Engine();
                    builder.Wheels();
                    builder.Light();

                    builder.Car();
                }
                Console.WriteLine("**********************************");
                {
                    AbstractBuilder builder = new BuilderBYD();
                    builder.Engine();
                    builder.Wheels();
                    builder.Light();

                    builder.Car();
                }
                Console.WriteLine("**********************************");
                {
                    AbstractBuilder builder = new BuilderBYD();

                    Director director = new Director(builder);
                    director.GetCar();
                }

                Console.WriteLine("**********************************");
                {
                    AbstractBuilder builder = new BuilderVolkswagen();
                    Director director = new Director(builder);
                    director.GetCar();
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