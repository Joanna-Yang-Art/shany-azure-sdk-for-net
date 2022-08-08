// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class GroupCallOutput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static GroupCallOutput DeserializeGroupCallOutput(JsonElement element)
        {
            string id = default;
            MediaOutputType kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new MediaOutputType(property.Value.GetString());
                    continue;
                }
            }
            return new GroupCallOutput(kind, id);
        }
    }
}
