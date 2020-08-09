using FactoryPattern.War3.Interface;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 工厂类
    /// </summary>
    public interface IFactory
    {
        IRace CreateInstance();
    }
}