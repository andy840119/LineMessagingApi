using Line.Messaging.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Line.Messaging.Json.Messages.Template
{
    internal class TemplateJsonConverter : JsonConverter<ITemplate>
    {
        public override ITemplate ReadJson(JsonReader reader, Type objectType, ITemplate existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);

            var containerType = jObject.Value<string>("type").ToEnum<TemplateType>();

            switch (containerType)
            {
                case TemplateType.Buttons:
                    return new ButtonsTemplate();
                case TemplateType.Carousel:
                    return new CarouselTemplate();
                case TemplateType.Confirm:
                    return new ConfirmTemplate();
                case TemplateType.Image_carousel:
                    return new ImageCarouselTemplate();
                default:
                    return null;
            }
        }

        public override void WriteJson(JsonWriter writer, ITemplate value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
