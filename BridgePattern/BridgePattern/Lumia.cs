using System;

namespace BridgePattern
{
    public class Lumia : BasePhone
    {
        public override string System()
        {
            return "Winphone";
        }

        public override string Version()
        {
            return "10.0";
        }

        public override void Call()
        {
            Console.WriteLine("Use OS {0}.{1}.{2} Call", this.GetType().Name, this.System(), this.Version());
        }

        public override void Text()
        {
            Console.WriteLine("Use OS {0}.{1}.{2} Text", this.GetType().Name, this.System(), this.Version());
        }
    }
}