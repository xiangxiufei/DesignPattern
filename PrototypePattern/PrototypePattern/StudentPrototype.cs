using System;
using System.Threading;

namespace PrototypePattern
{
    /// <summary>
    /// 原型类
    /// </summary>
    [Serializable]
    public class StudentPrototype
    {
        /// <summary>
        /// 1 构造函数私有化--避免随意构造
        /// </summary>
        private StudentPrototype()
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
        private static StudentPrototype _Student = new StudentPrototype()
        {
            Id = 123,
            Name = "ywa",
            Class = new Class()
            {
                ClassId = 1,
                ClassName = ".Net高级班"
            }
        };

        /// <summary>
        /// 2 公开的静态方法来提供实例
        /// </summary>
        /// <returns></returns>
        public static StudentPrototype CreateInstance()
        {
            StudentPrototype student = (StudentPrototype)_Student.MemberwiseClone();
            //MemberwiseClone:内存拷贝，不走构造函数，直接内存copy，所以没有性能损失；而且产生的是新对象----浅拷贝--只拷贝引用
            student.Class = new Class()
            {
                ClassId = student.Class.ClassId,
                ClassName = student.Class.ClassName
            };
            //把引用的地址重新赋值，完成了深copy--不仅拷贝引用，还得拷贝引用类型的值
            return student;
        }

        //deepcopy：1 直接new  2 子类型提供原型方式  3 序列化反序列化

        public static StudentPrototype CreateInstanceSerialize()
        {
            return SerializeHelper.DeepClone<StudentPrototype>(_Student);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Class Class { get; set; }

        public void Study()
        {
            Console.WriteLine("{0}在学习设计模式", this.Name);
        }
    }

    [Serializable]
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}