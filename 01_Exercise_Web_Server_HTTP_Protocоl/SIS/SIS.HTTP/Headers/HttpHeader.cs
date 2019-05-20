using SIS.HTTP.Common;

namespace SIS.HTTP.Headers
{
    public class HttpHeader
    {
        public HttpHeader(string key, string value)
        {
            CoreValidator.ThrowIfNullOrEmpty(text: key, name: nameof(key));
            CoreValidator.ThrowIfNullOrEmpty(text: value, name: nameof(value));

            Key = key;
            Value = value;
        }

        public string Key { get;}

        public string Value { get; }

        public override string ToString()
        {
            return $"{this.Key}: {this.Value}";
        }
    }
}
