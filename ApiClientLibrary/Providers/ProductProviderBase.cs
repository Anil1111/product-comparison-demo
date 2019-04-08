namespace ApiClientLibrary.Providers
{
    public abstract class ProductProviderBase<T> : IProductProvider<T>
    {
        public abstract T Get();
    }
}