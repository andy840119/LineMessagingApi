using Line.Messaging.Json.Messages.Template;
using Newtonsoft.Json;

namespace Line.Messaging
{
    [JsonConverter(typeof(TemplateJsonConverter))]
    public interface ITemplate
    {
        TemplateType Type { get; }
    }
}
