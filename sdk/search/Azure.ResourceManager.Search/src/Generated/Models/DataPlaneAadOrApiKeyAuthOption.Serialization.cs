// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Search.Models
{
    internal partial class DataPlaneAadOrApiKeyAuthOption : IUtf8JsonSerializable, IJsonModel<DataPlaneAadOrApiKeyAuthOption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataPlaneAadOrApiKeyAuthOption>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataPlaneAadOrApiKeyAuthOption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataPlaneAadOrApiKeyAuthOption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataPlaneAadOrApiKeyAuthOption)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AadAuthFailureMode))
            {
                writer.WritePropertyName("aadAuthFailureMode"u8);
                writer.WriteStringValue(AadAuthFailureMode.Value.ToSerialString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        DataPlaneAadOrApiKeyAuthOption IJsonModel<DataPlaneAadOrApiKeyAuthOption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataPlaneAadOrApiKeyAuthOption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataPlaneAadOrApiKeyAuthOption)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataPlaneAadOrApiKeyAuthOption(document.RootElement, options);
        }

        internal static DataPlaneAadOrApiKeyAuthOption DeserializeDataPlaneAadOrApiKeyAuthOption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SearchAadAuthFailureMode? aadAuthFailureMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aadAuthFailureMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aadAuthFailureMode = property.Value.GetString().ToSearchAadAuthFailureMode();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataPlaneAadOrApiKeyAuthOption(aadAuthFailureMode, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AadAuthFailureMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  aadAuthFailureMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AadAuthFailureMode))
                {
                    builder.Append("  aadAuthFailureMode: ");
                    builder.AppendLine($"'{AadAuthFailureMode.Value.ToSerialString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DataPlaneAadOrApiKeyAuthOption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataPlaneAadOrApiKeyAuthOption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DataPlaneAadOrApiKeyAuthOption)} does not support writing '{options.Format}' format.");
            }
        }

        DataPlaneAadOrApiKeyAuthOption IPersistableModel<DataPlaneAadOrApiKeyAuthOption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataPlaneAadOrApiKeyAuthOption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataPlaneAadOrApiKeyAuthOption(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataPlaneAadOrApiKeyAuthOption)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataPlaneAadOrApiKeyAuthOption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
