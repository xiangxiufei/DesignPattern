using System;

namespace SinglePattern
{
    public sealed class Singleton2
    {
        private Singleton2()
        {
            Console.WriteLine("构造函数...");
        }

        private static volatile Singleton2 instance = null;
        private static readonly object _lock = new object();

        //静态属性实现
        public static Singleton2 Instance
        {
            get
            {
                if (instance == null)//避免不必要的锁等待
                {
                    lock (_lock)//保证任意时刻只有一个线程进入，其他线程等待
                    {
                        if (instance == null)
                        {
                            instance = new Singleton2();
                        }
                    }
                }

                return instance;
            }
        }

        //静态方法实现
        public static Singleton2 CreateInstance()
        {
            if (instance == null)//避免不必要的锁等待
            {
                lock (_lock)//保证任意时刻只有一个线程进入，其他线程等待
                {
                    if (instance == null)
                    {
                        instance = new Singleton2();
                    }
                }
            }

            return instance;
        }

        public void Show()
        {
            Console.WriteLine("Show...");
        }
    }
}