using AbstractFactoryPattern.Sanguosha.Interface;
using AbstractFactoryPattern.Sanguosha.Service;

namespace AbstractFactoryPattern
{
    public class FactoryWu : AbstractFactory
    {
        public override IGroup CreateGroup()
        {
            return new GroupWu();
        }

        public override IGenerals CreateGenerals()
        {
            return new GeneralsWu();
        }
    }
}