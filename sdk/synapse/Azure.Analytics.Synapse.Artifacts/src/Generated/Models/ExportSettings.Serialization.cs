// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ExportSettingsConverter))]
    public partial class ExportSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static ExportSettings DeserializeExportSettings(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureDatabricksDeltaLakeExportCommand": return AzureDatabricksDeltaLakeExportCommand.DeserializeAzureDatabricksDeltaLakeExportCommand(element);
                    case "SnowflakeExportCopyCommand": return SnowflakeExportCopyCommand.DeserializeSnowflakeExportCopyCommand(element);
                }
            }
            return UnknownExportSettings.DeserializeUnknownExportSettings(element);
        }

        internal partial class ExportSettingsConverter : JsonConverter<ExportSettings>
        {
            public override void Write(Utf8JsonWriter writer, ExportSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ExportSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeExportSettings(document.RootElement);
            }
        }
    }
}
