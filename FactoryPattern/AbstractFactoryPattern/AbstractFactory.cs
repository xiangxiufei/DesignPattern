using AbstractFactoryPattern.Sanguosha.Interface;

namespace AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract IGroup CreateGroup();

        public abstract IGenerals CreateGenerals();
    }
}