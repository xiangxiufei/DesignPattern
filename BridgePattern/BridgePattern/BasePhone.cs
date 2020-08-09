namespace BridgePattern
{
    /// <summary>
    /// 抽象父类
    /// </summary>
    public abstract class BasePhone
    {
        public int Price { get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        public abstract string System();

        /// <summary>
        /// 系统版本
        /// </summary>
        public abstract string Version();

        /// <summary>
        /// 打电话
        /// </summary>
        public abstract void Call();

        /// <summary>
        /// 发短信
        /// </summary>
        public abstract void Text();
    }
}