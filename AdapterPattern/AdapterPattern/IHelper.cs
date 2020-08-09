namespace AdapterPattern
{
    /// <summary>
    /// 数据访问接口
    /// </summary>
    public interface IHelper
    {
        void Add<T>();

        void Delete<T>();

        void Update<T>();

        void Query<T>();
    }
}