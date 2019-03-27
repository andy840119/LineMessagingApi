using Line.Messaging.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Line.Messaging.Json.Messages
{
    internal class MessageJsonConverter : JsonConverter<ISendMessage>
    {
        public override ISendMessage ReadJson(JsonReader reader, Type objectType, ISendMessage existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);

            var containerType = jObject.Value<string>("type").ToEnum<MessageType>();

            switch (containerType)
            {
                case MessageType.Audio:
                    return new AudioMessage();
                case MessageType.Flex:
                    return new FlexMessage();
                case MessageType.Imagemap:
                    return new ImagemapMessage();
                case MessageType.Image:
                    return new ImageMessage();
                case MessageType.Location:
                    return new LocationMessage();
                case MessageType.Sticker:
                    return new StickerMessage();
                case MessageType.Template:
                    return new TemplateMessage();
                case MessageType.Text:
                    return new TextMessage();
                case MessageType.Video:
                    return new VideoMessage();
                default:
                    return null;
            }
        }

        public override void WriteJson(JsonWriter writer, ISendMessage value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
