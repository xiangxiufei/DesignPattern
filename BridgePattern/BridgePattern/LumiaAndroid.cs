using System;

namespace BridgePattern
{
    public class LumiaAndroid : BasePhone
    {
        public override string System()
        {
            return "Android";
        }

        public override string Version()
        {
            return "6.0";
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