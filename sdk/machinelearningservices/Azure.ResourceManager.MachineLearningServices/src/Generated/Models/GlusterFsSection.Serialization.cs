// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class GlusterFsSection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("serverAddress");
            writer.WriteStringValue(ServerAddress);
            writer.WritePropertyName("volumeName");
            writer.WriteStringValue(VolumeName);
            writer.WriteEndObject();
        }

        internal static GlusterFsSection DeserializeGlusterFsSection(JsonElement element)
        {
            string serverAddress = default;
            string volumeName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serverAddress"))
                {
                    serverAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("volumeName"))
                {
                    volumeName = property.Value.GetString();
                    continue;
                }
            }
            return new GlusterFsSection(serverAddress, volumeName);
        }
    }
}