// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Rendering
{
    public partial class RenderCopyright
    {
        internal static RenderCopyright DeserializeRenderCopyright(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string formatVersion = default;
            IReadOnlyList<string> generalCopyrights = default;
            IReadOnlyList<RegionalCopyright> regions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("formatVersion"u8))
                {
                    formatVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("generalCopyrights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    generalCopyrights = array;
                    continue;
                }
                if (property.NameEquals("regions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RegionalCopyright> array = new List<RegionalCopyright>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RegionalCopyright.DeserializeRegionalCopyright(item));
                    }
                    regions = array;
                    continue;
                }
            }
            return new RenderCopyright(formatVersion, generalCopyrights ?? new ChangeTrackingList<string>(), regions ?? new ChangeTrackingList<RegionalCopyright>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RenderCopyright FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeRenderCopyright(document.RootElement);
        }
    }
}
