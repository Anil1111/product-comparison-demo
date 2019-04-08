using System.Text;

using Newtonsoft.Json;

namespace ApiClientLibrary.Serialization
{
    public sealed class JsonSerializationProvider<T> : SerializationProviderBase<T>
    {
        public JsonSerializationProvider(Encoding encoding)
            : base(encoding)
        {
        }

        public override T Deserialize(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        public override string Serialize(T value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}