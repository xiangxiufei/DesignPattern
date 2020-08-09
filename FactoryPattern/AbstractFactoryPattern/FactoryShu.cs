using AbstractFactoryPattern.Sanguosha.Interface;
using AbstractFactoryPattern.Sanguosha.Service;

namespace AbstractFactoryPattern
{
    public class FactoryShu : AbstractFactory
    {
        public override IGroup CreateGroup()
        {
            return new GroupShu();
        }

        public override IGenerals CreateGenerals()
        {
            return new GeneralsShu();
        }
    }
}