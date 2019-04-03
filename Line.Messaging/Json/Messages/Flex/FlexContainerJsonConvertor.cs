using Line.Messaging.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Line.Messaging.Json.Messages.Flex
{
    internal class FlexContainerJsonConvertor : JsonConverter<IFlexContainer>
    {
        public override IFlexContainer ReadJson(JsonReader reader, Type objectType, IFlexContainer existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);

            var containerType = jObject.Value<string>("type").ToEnum<FlexContainerType>();

            switch (containerType)
            {
                case FlexContainerType.Bubble:
                    return new BubbleContainer
                    {
                        //Hero = new ImageComponent(),
                    };
                case FlexContainerType.Carousel:
                    return new CarouselContainer();
                default:
                    return null;
            }
        }

        public override void WriteJson(JsonWriter writer, IFlexContainer value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
