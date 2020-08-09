using System;

namespace AdapterPattern
{
    public class CacheHelper
    {
        public void AddRedis<T>()
        {
            Console.WriteLine("This is {0} Add", this.GetType().Name);
        }

        public void DeleteRedis<T>()
        {
            Console.WriteLine("This is {0} Delete", this.GetType().Name);
        }

        public void UpdateRedis<T>()
        {
            Console.WriteLine("This is {0} Update", this.GetType().Name);
        }

        public void QueryRedis<T>()
        {
            Console.WriteLine("This is {0} Query", this.GetType().Name);
        }
    }
}