using FactoryPattern.War3.Interface;
using FactoryPattern.War3.Service;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 工厂类
    /// </summary>
    public class NEFactory : IFactory
    {
        public IRace CreateInstance()
        {
            IRace race = new NE();
            return race;
        }
    }
}