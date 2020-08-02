using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SinglePattern
{
    /// <summary>
    /// 1 单例模式(单线程和多线程)
    /// 2 单例模式三种写法
    /// 3 单例模式的优缺点
    /// 4 深度探讨单例模式应用场景
    ///
    /// 单式有什么用？
    ///     程序只需要这个对象实例化一次
    ///
    ///     数据库连接池：非托管资源（申请、释放非常消耗性能）
    ///                   池化资源---内置10个连接---使用来拿，用完放回来---避免重复申请和销毁
    ///                   ---控制链接数量
    ///
    ///     线程池---流水号生成器---配置文件读取---IOC容器实例）
    ///
    /// </summary>
    internal class Program
    {
        private async static Task Main(string[] args)
        {
            {
                //最基本的单例模式 60分
                //for (int i = 0; i < 5; i++)
                //{
                //    Singleton1 singleton = Singleton1.CreateInstance();
                //    singleton.Show();
                //}
            }

            {
                //for (int i = 0; i < 5; i++)
                //{
                //    Task.Run(() =>
                //    {
                //        Singleton1 singleton = Singleton1.CreateInstance();
                //        singleton.Show();
                //    });
                //}

                // 懒汉式 1
                //for (int i = 0; i < 5; i++)
                //{
                //    Task.Run(() =>
                //    {
                //        Singleton2 singleton = Singleton2.CreateInstance();
                //        singleton.Show();
                //    });
                //}
            }

            {
                //饿汉式 2、3
                //for (int i = 0; i < 5; i++)
                //{
                //    Task.Run(() =>
                //    {
                //        //Singleton3 singleton = Singleton3.CreateInstance();
                //        //singleton.Show();

                //        Singleton4 singleton = Singleton4.CreateInstance();
                //        singleton.Show();
                //    });
                //}
            }

            {
                for (int i = 0; i < 10000; i++)
                {
                    await Task.Run(() =>
                    {
                        Singleton2 singleton = Singleton2.CreateInstance();
                        singleton.Invoke();
                    });
                }

                {
                    Singleton2 singleton = Singleton2.CreateInstance();
                    Console.WriteLine(singleton.Num);
                }
            }

            Console.Read();
        }
    }
}