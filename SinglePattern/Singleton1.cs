using System;
using System.Threading;

namespace SinglePattern
{
    public class Singleton1
    {
        private Singleton1()
        {
            Console.WriteLine("构造函数...");
        }

        private static Singleton1 _Singleton1 = null;

        public static Singleton1 CreateInstance()
        {
            if (_Singleton1 == null)
            {
                _Singleton1 = new Singleton1();
            }

            return _Singleton1;
        }

        public void Show()
        {
            Console.WriteLine("Show...");
        }
    }
}