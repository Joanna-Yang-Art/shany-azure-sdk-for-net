// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class LinkedIntegrationRuntimeKeyAuthorization : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("key");
            writer.WriteObjectValue(Key);
            writer.WritePropertyName("authorizationType");
            writer.WriteStringValue(AuthorizationType);
            writer.WriteEndObject();
        }

        internal static LinkedIntegrationRuntimeKeyAuthorization DeserializeLinkedIntegrationRuntimeKeyAuthorization(JsonElement element)
        {
            FactorySecretString key = default;
            string authorizationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"))
                {
                    key = FactorySecretString.DeserializeFactorySecretString(property.Value);
                    continue;
                }
                if (property.NameEquals("authorizationType"))
                {
                    authorizationType = property.Value.GetString();
                    continue;
                }
            }
            return new LinkedIntegrationRuntimeKeyAuthorization(authorizationType, key);
        }
    }
}
