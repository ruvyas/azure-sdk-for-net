// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageSkuRestriction
    {
        internal static StorageSkuRestriction DeserializeStorageSkuRestriction(JsonElement element)
        {
            Optional<string> type = default;
            Optional<IReadOnlyList<string>> values = default;
            Optional<StorageRestrictionReasonCode> reasonCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("reasonCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reasonCode = new StorageRestrictionReasonCode(property.Value.GetString());
                    continue;
                }
            }
            return new StorageSkuRestriction(type.Value, Optional.ToList(values), Optional.ToNullable(reasonCode));
        }
    }
}
