namespace BridgePattern.Bridge
{
    public class WinphoneSystem : ISystem
    {
        public string System()
        {
            return "Winphone";
        }

        public string Version()
        {
            return "10.0";
        }
    }
}