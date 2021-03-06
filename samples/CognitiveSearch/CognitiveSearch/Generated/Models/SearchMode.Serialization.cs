// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CognitiveSearch.Models
{
    internal static class SearchModeExtensions
    {
        public static string ToSerialString(this SearchMode value) => value switch
        {
            SearchMode.Any => "any",
            SearchMode.All => "all",
            SearchMode.AnalyzingInfixMatching => "analyzingInfixMatching",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SearchMode value.")
        };

        public static SearchMode ToSearchMode(this string value)
        {
            if (string.Equals(value, "any", StringComparison.InvariantCultureIgnoreCase)) return SearchMode.Any;
            if (string.Equals(value, "all", StringComparison.InvariantCultureIgnoreCase)) return SearchMode.All;
            if (string.Equals(value, "analyzingInfixMatching", StringComparison.InvariantCultureIgnoreCase)) return SearchMode.AnalyzingInfixMatching;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SearchMode value.");
        }
    }
}
