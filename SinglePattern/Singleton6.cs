using System;

namespace SinglePattern
{
    public sealed class Singleton6
    {
        private Singleton6()
        {
            Console.WriteLine("构造函数...");
        }

        private static readonly Lazy<Singleton6> lazy = new Lazy<Singleton6>(() => new Singleton6());

        public static Singleton6 Instance { get { return lazy.Value; } }

        public void Show()
        {
            Console.WriteLine("Show...");
        }
    }
}