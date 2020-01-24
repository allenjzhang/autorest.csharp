// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Core
{
    internal class CodeGenSchemaAttribute : Attribute
    {
        public string SchemaName { get; }

        public CodeGenSchemaAttribute(string schemaName)
        {
            SchemaName = schemaName;
        }
    }
}