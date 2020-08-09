namespace BuilderPattern
{
    /// <summary>
    /// 工人抽象
    /// </summary>
    public abstract class AbstractBuilder
    {
        public abstract void Engine();

        public abstract void Wheels();

        public abstract void Light();

        public abstract Car Car();
    }
}