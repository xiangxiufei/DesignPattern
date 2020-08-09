using System;

namespace BridgePattern.Bridge
{
    public class GalaxyBridge : BasePhoneBridge
    {
        public override void Call()
        {
            Console.WriteLine("Use OS {0}.{1}.{2} Call", this.GetType().Name, this.SystemVersion.System(), this.SystemVersion.Version());
        }

        public override void Text()
        {
            Console.WriteLine("Use OS {0}.{1}.{2} Text", this.GetType().Name, this.SystemVersion.System(), this.SystemVersion.Version());
        }
    }
}