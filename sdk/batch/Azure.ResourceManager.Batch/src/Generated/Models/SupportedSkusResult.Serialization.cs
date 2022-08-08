// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    internal partial class SupportedSkusResult
    {
        internal static SupportedSkusResult DeserializeSupportedSkusResult(JsonElement element)
        {
            IReadOnlyList<BatchSupportedSku> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<BatchSupportedSku> array = new List<BatchSupportedSku>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchSupportedSku.DeserializeBatchSupportedSku(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SupportedSkusResult(value, nextLink.Value);
        }
    }
}
