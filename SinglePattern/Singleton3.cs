using System;

namespace SinglePattern
{
    public sealed class Singleton3
    {
        private Singleton3()
        {
            Console.WriteLine("构造函数...");
        }

        private static Singleton3 instance = null;

        /// <summary>
        /// 静态构造函数：由CLR保证，在第一次使用到这个类型之前，自动被调用且只调用一次
        /// </summary>
        static Singleton3()
        {
            instance = new Singleton3();
        }

        //静态属性实现
        public static Singleton3 Instance
        {
            get
            {
                return instance;
            }
        }

        //静态方法实现
        public static Singleton3 CreateInstance()
        {
            return instance;
        }

        public void Show()
        {
            Console.WriteLine("Show...");
        }
    }
}