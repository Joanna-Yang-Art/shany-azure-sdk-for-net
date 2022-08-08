// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    internal partial class NetworkSecurityGroupResourceReferenceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceArmResourceId");
            writer.WriteStringValue(SourceArmResourceId);
            writer.WriteEndObject();
        }

        internal static NetworkSecurityGroupResourceReferenceInfo DeserializeNetworkSecurityGroupResourceReferenceInfo(JsonElement element)
        {
            ResourceIdentifier sourceArmResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceArmResourceId"))
                {
                    sourceArmResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new NetworkSecurityGroupResourceReferenceInfo(sourceArmResourceId);
        }
    }
}
