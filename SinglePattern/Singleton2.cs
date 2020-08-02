using System;
using System.Threading;

namespace SinglePattern
{
    public sealed class Singleton2
    {
        private Singleton2()
        {
            Console.WriteLine("构造函数...");
        }

        private volatile static Singleton2 _Singleton2 = null;
        private static readonly object _lock = new object();

        public static Singleton2 CreateInstance()
        {
            if (_Singleton2 == null)//避免不必要的锁等待
            {
                lock (_lock)//保证任意时刻只有一个线程进入，其他线程等待
                {
                    if (_Singleton2 == null)
                    {
                        _Singleton2 = new Singleton2();
                    }
                }
            }

            return _Singleton2;
        }

        public void Show()
        {
            Console.WriteLine("Show...");
        }

        public int Num = 0;

        public void Invoke()
        {
            this.Num++;
        }
    }
}