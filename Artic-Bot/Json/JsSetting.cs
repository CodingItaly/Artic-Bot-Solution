/* 
 
  <=[Artic-Bot]=>
  
  [Author] - Ilkay Solotov
  [CreationDate] - 12/12/20
  [LastUpdate] - 12/12/20

    i might have a obsessive-compulsive disorder
    but honestly i like formatting all variables, spaces
    and other stuff too soo... feel free to delete this ton of shit and 
    reformat it but i like it so... ;)

*/

/* ɪ ᴋɴᴏᴡ ᴍᴏꜱᴛ ᴏꜰ ᴛʜᴏꜱᴇ ꜰᴏʀᴍᴀᴛᴛɪɴɢ ᴛʏᴘᴇꜱ ᴀʀᴇ ᴄᴏᴍᴘʟᴇᴛᴇʟʏ
    ᴡʀᴏɴɢ, ʙᴜᴛ ɪᴛꜱ ᴍʏ ᴘᴇʀꜱᴏɴᴀʟ ᴡᴀʏ ᴛᴏ ꜰᴏʀᴍᴀᴛ ᴍʏ ᴄᴏᴅᴇ :+) */

using System;
using System.IO;
using System.Globalization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Artic_Bot.Global;

namespace Artic_Bot.JsSettings
{
    class DeSeRialize
    {
        Variable var = new Variable();
        Setting self = new Setting();
        public void serialize()
        {
            File.WriteAllText(var.chatId.ToString(), JsonConvert.SerializeObject(self, Converter.Settings));
        }
        public void deserialize()
        {
            JsonConvert.DeserializeObject<Setting>(File.ReadAllText(var.chatId.ToString()), Converter.Settings);
        }
    }
    public partial class Setting
    {
        [JsonProperty("join")]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool Join { get; set; }
        //
        [JsonProperty("Leave")]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool Leave { get; set; }
        //
        [JsonProperty("changeTitle")]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool ChangeTitle { get; set; }
    }
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(bool) || t == typeof(bool?);
        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            bool b;
            if (Boolean.TryParse(value, out b))
            {
                return b;
            }
            throw new Exception("Cannot unmarshal type bool");
        }
        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (bool)untypedValue;
            var boolString = value ? "true" : "false";
            serializer.Serialize(writer, boolString);
            return;
        }
        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}