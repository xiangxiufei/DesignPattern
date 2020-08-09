using System;
using System.Threading;

namespace PrototypePattern
{
    /// <summary>
    /// 普通类
    /// 创建的时候很耗时  耗资源等
    /// </summary>
    public class Student
    {
        public Student()
        {
            Thread.Sleep(2000);
            long lResult = 0;
            for (int i = 0; i < 1000000; i++)
            {
                lResult += i;
            }
            Console.WriteLine("{0}被构造..", this.GetType().Name);
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public void Study()
        {
            Console.WriteLine("{0}在学习设计模式", this.Name);
        }
    }
}