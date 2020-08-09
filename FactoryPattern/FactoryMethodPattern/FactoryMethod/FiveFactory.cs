using FactoryPattern.War3.Interface;
using FactoryPattern.War3.ServiceExtend;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 工厂类
    /// </summary>
    public class FiveFactory : IFactory
    {
        public IRace CreateInstance()
        {
            IRace race = new Five();
            return race;
        }
    }
}