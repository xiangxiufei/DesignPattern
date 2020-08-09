using AbstractFactoryPattern.Sanguosha.Interface;
using AbstractFactoryPattern.Sanguosha.Service;

namespace AbstractFactoryPattern
{
    public class FactoryWei : AbstractFactory
    {
        public override IGroup CreateGroup()
        {
            return new GroupWei();
        }

        public override IGenerals CreateGenerals()
        {
            return new GeneralsWei();
        }
    }
}