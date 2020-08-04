using System;
using System.Threading.Tasks;

namespace SinglePattern
{
    /// <summary>
    /// 单例模式：保证一个类仅有一个实例，并提供一个访问它的全局访问点。
    ///
    /// 注意点： sealed关键字
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Singleton 1
            {
                //我们很容易就能想到这种写法

                //单线程下，结果是符合预期的
                //for (int i = 0; i < 5; i++)
                //{
                //    // var singleton = Singleton1.CreateInstance();
                //    var singleton = Singleton1.Instance;
                //    singleton.Show();
                //}

                //但是在多线程下，结果与我们预期就不符合了
                //for (int i = 0; i < 5; i++)
                //{
                //    Task.Run(() =>
                //    {
                //        // var singleton = Singleton1.CreateInstance();
                //        var singleton = Singleton1.Instance;
                //        singleton.Show();
                //    });
                //}
            }

            // Singleton 2 “双重锁定”
            {
                //for (int i = 0; i < 5; i++)
                //{
                //    Task.Run(() =>
                //    {
                //        //var singleton = Singleton2.CreateInstance();
                //        var singleton = Singleton2.Instance;
                //        singleton.Show();
                //    });
                //}
            }

            // Singleton 3 静态构造函数
            {
                //for (int i = 0; i < 5; i++)
                //{
                //    Task.Run(() =>
                //    {
                //        //var singleton = Singleton3.CreateInstance();
                //        var singleton = Singleton3.Instance;
                //        singleton.Show();
                //    });
                //}
            }

            // Singleton 4 静态字段
            {
                //for (int i = 0; i < 5; i++)
                //{
                //    Task.Run(() =>
                //    {
                //        //var singleton = Singleton4.CreateInstance();
                //        var singleton = Singleton3.Instance;
                //        singleton.Show();
                //    });
                //}
            }

            //Singleton 5 嵌套类的静态成员
            {
                //for (int i = 0; i < 5; i++)
                //{
                //    Task.Run(() =>
                //    {
                //        var singleton = Singleton5.Instance;
                //        singleton.Show();
                //    });
                //}
            }

            // Singleton 6 Lazy类型
            {
                for (int i = 0; i < 5; i++)
                {
                    Task.Run(() =>
                    {
                        var singleton = Singleton6.Instance;
                        singleton.Show();
                    });
                }
            }

            Console.Read();
        }
    }
}