using System.Text;

namespace ApiClientLibrary.Serialization
{
    public abstract class SerializationProviderBase<T> : ISerializationProvider<T>
    {
        protected SerializationProviderBase(Encoding encoding)
        {
            Encoding = encoding;
        }

        public Encoding Encoding { get; }

        public abstract T Deserialize(string value);
        public abstract string Serialize(T value);
    }
}