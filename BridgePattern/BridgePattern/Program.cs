using BridgePattern.Bridge;
using System;

namespace BridgePattern
{
    /// <summary>
    /// 1 多重继承与变化封装
    /// 2 桥接模式：解决多维度的变化
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("******************************");
            {
                BasePhone phone = new iPhone();
                phone.Call();
                phone.Text();
            }
            Console.WriteLine("******************************");
            {
                BasePhone phone = new Galaxy();
                phone.Call();
                phone.Text();
            }
            Console.WriteLine("******************************");
            {
                BasePhone phone = new iPhoneAndroid();
                phone.Call();
                phone.Text();
            }
            Console.WriteLine("******************************");
            {
                BasePhone phone = new GalaxyIOS();
                phone.Call();
                phone.Text();
            }

            ISystem android = new AndroidSystem();
            ISystem ios = new IOSSystem();
            ISystem winphone = new WinphoneSystem();

            Console.WriteLine("******************************");
            {
                BasePhoneBridge phone = new GalaxyBridge();
                phone.SystemVersion = android;
                phone.Call();
                phone.Text();
            }
            {
                BasePhoneBridge phone = new GalaxyBridge();
                phone.SystemVersion = ios;
                phone.Call();
                phone.Text();
            }
            {
                BasePhoneBridge phone = new GalaxyBridge();
                phone.SystemVersion = winphone;
                phone.Call();
                phone.Text();
            }
            Console.Read();
        }
    }
}