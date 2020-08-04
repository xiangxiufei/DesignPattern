using System;

namespace SinglePattern
{
    public sealed class Singleton5
    {
        private Singleton5()
        {
            Console.WriteLine("构造函数...");
        }

        public static Singleton5 Instance { get { return Nested.instance; } }

        private static class Nested
        {
            static Nested()
            {
            }

            internal static readonly Singleton5 instance = new Singleton5();
        }

        public void Show()
        {
            Console.WriteLine("Show...");
        }
    }
}