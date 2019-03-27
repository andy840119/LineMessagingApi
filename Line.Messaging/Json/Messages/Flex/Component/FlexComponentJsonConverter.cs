using Line.Messaging.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Line.Messaging.Json.Messages.Flex.Component
{
    internal class FlexComponentJsonConverter : JsonConverter<IFlexComponent>
    {
        public override IFlexComponent ReadJson(JsonReader reader, Type objectType, IFlexComponent existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);

            var containerType = jObject.Value<string>("type").ToEnum<FlexComponentType>();

            switch (containerType)
            {
                case FlexComponentType.Box:
                    return new BoxComponent();
                case FlexComponentType.Button:
                    return new ButtonComponent();
                case FlexComponentType.Filler:
                    return new FillerComponent();
                case FlexComponentType.Icon:
                    return new IconComponent();
                case FlexComponentType.Image:
                    return new ImageComponent();
                case FlexComponentType.Separator:
                    return new SeparatorComponent();
                case FlexComponentType.Spacer:
                    return new SpacerComponent();
                case FlexComponentType.Text:
                    return new TextComponent();
                default:
                    return null;
            }
        }

        public override void WriteJson(JsonWriter writer, IFlexComponent value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
