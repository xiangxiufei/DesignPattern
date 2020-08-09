using FactoryPattern.War3.Interface;
using System;

namespace FactoryPattern.War3.Service
{
    /// <summary>
    /// war3种族之一
    /// </summary>
    public class NE : IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("The King of {0} is Moon", this.GetType().Name);
        }
    }
}