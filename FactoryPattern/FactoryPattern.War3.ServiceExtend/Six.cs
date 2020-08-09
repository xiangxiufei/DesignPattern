using FactoryPattern.War3.Interface;
using System;

namespace FactoryPattern.War3.ServiceExtend
{
    /// <summary>
    /// war3种族之一
    /// </summary>
    public class Six : IRace
    {
        public Six(string name, int id, object special, IRace race1, IRace race2, IRace race3)
        {
        }

        public void ShowKing()
        {
            Console.WriteLine("The King of {0} is 悠悠吾心", this.GetType().Name);
        }
    }
}