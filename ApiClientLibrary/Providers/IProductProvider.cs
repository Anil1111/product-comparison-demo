namespace ApiClientLibrary.Providers
{
    public interface IProductProvider<T>
    {
        T Get();
    }
}