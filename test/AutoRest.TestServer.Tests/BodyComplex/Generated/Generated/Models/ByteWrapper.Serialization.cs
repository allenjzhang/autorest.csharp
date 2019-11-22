// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;

namespace BodyComplex.Models.V20160229
{
    public partial class ByteWrapper
    {
        internal void Serialize(Utf8JsonWriter writer, bool includeName = true)
        {
            if (includeName)
            {
                writer.WriteStartObject("byte-wrapper");
            }
            else
            {
                writer.WriteStartObject();
            }
            if (Field != null)
            {
                // ByteArraySchema Field: Not Implemented
            }
            writer.WriteEndObject();
        }
        internal static ByteWrapper Deserialize(JsonElement element)
        {
            var result = new ByteWrapper();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field"))
                {
                    // ByteArraySchema Field: Not Implemented
                    continue;
                }
            }
            return result;
        }
    }
}