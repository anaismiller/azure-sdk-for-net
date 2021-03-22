// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class DataMaskingRuleListResult
    {
        internal static DataMaskingRuleListResult DeserializeDataMaskingRuleListResult(JsonElement element)
        {
            Optional<IReadOnlyList<DataMaskingRule>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataMaskingRule> array = new List<DataMaskingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataMaskingRule.DeserializeDataMaskingRule(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DataMaskingRuleListResult(Optional.ToList(value));
        }
    }
}
