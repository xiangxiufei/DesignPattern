namespace BridgePattern.Bridge
{
    public class AndroidSystem : ISystem
    {
        public string System()
        {
            return "Android";
        }

        public string Version()
        {
            return "6.0";
        }
    }
}