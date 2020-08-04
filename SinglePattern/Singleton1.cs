using System;

namespace SinglePattern
{
    public sealed class Singleton1
    {
        private Singleton1()
        {
            Console.WriteLine("构造函数...");
        }

        private static Singleton1 instance = null;

        //使用静态属性或者静态方法都可以实现

        //静态属性实现
        public static Singleton1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton1();
                }

                return instance;
            }
        }

        //静态方法实现
        public static Singleton1 CreateInstance()
        {
            if (instance == null)
            {
                instance = new Singleton1();
            }

            return instance;
        }

        public void Show()
        {
            Console.WriteLine("Show...");
        }
    }
}