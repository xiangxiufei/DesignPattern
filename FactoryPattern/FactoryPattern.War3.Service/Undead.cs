﻿using FactoryPattern.War3.Interface;
using System;

namespace FactoryPattern.War3.Service
{
    /// <summary>
    /// war3种族之一
    /// </summary>
    public class Undead : IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("The King of {0} is Gostop", this.GetType().Name);
        }
    }
}