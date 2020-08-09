using System;

namespace PrototypePattern
{
    /// <summary>
    /// 1 原型模式
    /// 2 浅克隆VS深克隆，原型模式的应用
    /// 3 C#内存分配机制详析
    ///
    /// 原型模式也就是用利用对象copy，快速获取对象---需要大量新对象的时候
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                {
                    //Console.WriteLine("***************Common**************");
                    ////对象复用---循环的就最简单了---不同的方法/类/线程/类库--重用对象
                    //Student student = new Student()
                    //{
                    //    Id = 1121,
                    //    Name = "张三"
                    //};
                    //for (int i = 0; i < 5; i++)
                    //{
                    //    //Student student = new Student()
                    //    //{
                    //    //    Id = 1121,
                    //    //    Name = "张三"
                    //    //};
                    //    student.Study();
                    //}
                }
                {
                    //Console.WriteLine("***************Singleton**************");
                    ////单例模式：保证整个进程中，该对象只有一个实例
                    //for (int i = 0; i < 5; i++)
                    //{
                    //    StudentSingleton student = StudentSingleton.CreateInstance();
                    //    student.Study();
                    //}
                }
                {
                    //Console.WriteLine("***************Singleton**************");
                    //StudentSingleton student1 = StudentSingleton.CreateInstance();
                    //StudentSingleton student2 = StudentSingleton.CreateInstance();
                    //student1.Id = 234;
                    //student1.Name = "张三";

                    //student2.Id = 345;
                    //student2.Name = "李四";

                    //student1.Study();
                    //student2.Study();
                }

                {
                    //Console.WriteLine("***************Prototype**************");
                    //for (int i = 0; i < 5; i++)
                    //{
                    //    StudentPrototype student = StudentPrototype.CreateInstance();
                    //    student.Study();
                    //}
                }
                {
                    Console.WriteLine("***************Prototype**************");
                    StudentPrototype student1 = StudentPrototype.CreateInstance();
                    StudentPrototype student2 = StudentPrototype.CreateInstance();
                    StudentPrototype student3 = StudentPrototype.CreateInstance();
                    student1.Id = 234;
                    student1.Name = "张三";
                    student1.Class.ClassId = 2;
                    student1.Class.ClassName = "班级2";

                    student2.Id = 345;
                    student2.Name = "李四";
                    student2.Class.ClassId = 3;
                    student2.Class.ClassName = "班级3";

                    student3.Id = 456;
                    student3.Name = "王五";
                    student3.Class = new Class()
                    {
                        ClassId = 4,
                        ClassName = "班级4"
                    };

                    student1.Study();
                    student2.Study();
                    student3.Study();
                }

                {
                    //C#内存分  进程堆(进程唯一)-----线程栈(每个线程一个)
                    //引用类型在堆里，值类型在栈里---变量都在栈里
                    //引用类型对象里面的值类型---student1.Id 堆还是栈？---在堆里
                    //值类型里面的引用类型---Custom.Name 堆还是栈？----在堆里(任何引用类型的值都在堆里)
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }

        private static void Show()
        {
            Console.WriteLine("***************Show**************");
            for (int i = 0; i < 5; i++)
            {
                Student student = new Student()
                {
                    Id = 1121,
                    Name = "张三"
                };
                student.Study();
            }
        }
    }

    public struct Custom
    {
        public string Name;
    }
}