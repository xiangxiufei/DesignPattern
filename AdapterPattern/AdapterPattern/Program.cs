using System;

namespace AdapterPattern
{
    /// <summary>
    /// 1 适配器模式概述
    /// 2 类适配器模式和对象适配器模式
    /// 3 适配器模式的应用
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*****************************");
                {
                    IHelper helper = new SqlserverHelper();
                    helper.Add<string>();
                    helper.Delete<string>();
                    helper.Update<string>();
                    helper.Query<string>();
                }

                Console.WriteLine("*****************************");
                {
                    IHelper helper = new MysqlHelper();
                    helper.Add<Program>();
                    helper.Delete<Program>();
                    helper.Update<Program>();
                    helper.Query<Program>();
                }

                Console.WriteLine("*****************************");
                {
                    IHelper helper = new OracleHelper();
                    helper.Add<Program>();
                    helper.Delete<Program>();
                    helper.Update<Program>();
                    helper.Query<Program>();
                }

                //类适配器模式
                Console.WriteLine("*****************************");
                {
                    IHelper helper = new RedisHelperClass(); //new RedisHelper();
                    helper.Add<Program>();
                    helper.Delete<Program>();
                    helper.Update<Program>();
                    helper.Query<Program>();

                    //强耦合   继承的
                    RedisHelperClass redis = new RedisHelperClass();
                    redis.Add<Program>();
                    redis.AddRedis<Program>();
                }

                //对象适配器模式
                Console.WriteLine("*****************************");
                {
                    IHelper helper = new RedisHelperObject(); //new RedisHelper();
                    helper.Add<Program>();
                    helper.Delete<Program>();
                    helper.Update<Program>();
                    helper.Query<Program>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}