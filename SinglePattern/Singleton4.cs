using System;

namespace SinglePattern
{
    public sealed class Singleton4
    {
        private Singleton4()
        {
            Console.WriteLine("构造函数...");
        }

        /// <summary>
        /// 静态字段：由CLR保障，在第一次使用到这个类型之前，自动被调用且只调用一次
        /// </summary>
        private static Singleton4 _Singleton4 = new Singleton4();

        public static Singleton4 CreateInstance()
        {
            return _Singleton4;
        }

        public void Show()
        {
            Console.WriteLine("Show...");
        }
    }
}