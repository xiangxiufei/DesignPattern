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
        private static Singleton4 instance = new Singleton4();

        //静态属性实现
        public static Singleton4 Instance
        {
            get
            {
                return instance;
            }
        }

        //静态方法实现
        public static Singleton4 CreateInstance()
        {
            return instance;
        }

        public void Show()
        {
            Console.WriteLine("Show...");
        }
    }
}