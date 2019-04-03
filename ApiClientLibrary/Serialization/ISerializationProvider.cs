using System.Text;

namespace ApiClientLibrary.Serialization
{
    public interface ISerializationProvider<T>
    {
        Encoding Encoding { get; }

        T Deserialize(string value);
        string Serialize(T value);
    }
}