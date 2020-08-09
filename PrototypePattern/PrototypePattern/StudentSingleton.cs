using System;
using System.Threading;

namespace PrototypePattern
{
    /// <summary>
    /// 单例类
    /// </summary>
    public class StudentSingleton
    {
        /// <summary>
        /// 1 构造函数私有化--避免随意构造
        /// </summary>
        private StudentSingleton()
        {
            Thread.Sleep(2000);
            long lResult = 0;
            for (int i = 0; i < 1000000; i++)
            {
                lResult += i;
            }
            Console.WriteLine("{0}被构造..", this.GetType().Name);
        }

        /// <summary>
        /// 3 私有的静态字段--内存唯一，不会释放，且在第一次使用这个类被初始化且只初始化一次
        /// </summary>
        private static StudentSingleton _Student = new StudentSingleton()
        {
            Id = 123,
            Name = "ywa"
        };

        /// <summary>
        /// 2 公开的静态方法来提供实例
        /// </summary>
        /// <returns></returns>
        public static StudentSingleton CreateInstance()
        {
            return _Student;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public void Study()
        {
            Console.WriteLine("{0}在学习设计模式", this.Name);
        }
    }
}