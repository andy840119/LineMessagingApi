using Line.Messaging.Json.Messages.Flex;
using Newtonsoft.Json;

namespace Line.Messaging
{
    [JsonConverter(typeof(FlexContainerJsonConvertor))]
    public interface IFlexContainer
    {
        FlexContainerType Type { get; }
    }
}
