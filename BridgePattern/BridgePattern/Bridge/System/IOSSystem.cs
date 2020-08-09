namespace BridgePattern.Bridge
{
    public class IOSSystem : ISystem
    {
        public string System()
        {
            return "IOS";
        }

        public string Version()
        {
            return "9.4";
        }
    }
}