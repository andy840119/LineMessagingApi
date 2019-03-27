using Line.Messaging.Json.Messages.Flex.Component;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Line.Messaging
{
    [JsonConverter(typeof(FlexComponentJsonConverter))]
    public interface IFlexComponent
    {
        FlexComponentType Type { get; }
    }
}
