// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class BatchAccountKeySourceExtensions
    {
        public static string ToSerialString(this BatchAccountKeySource value) => value switch
        {
            BatchAccountKeySource.MicrosoftBatch => "Microsoft.Batch",
            BatchAccountKeySource.MicrosoftKeyVault => "Microsoft.KeyVault",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchAccountKeySource value.")
        };

        public static BatchAccountKeySource ToBatchAccountKeySource(this string value)
        {
            if (string.Equals(value, "Microsoft.Batch", StringComparison.InvariantCultureIgnoreCase)) return BatchAccountKeySource.MicrosoftBatch;
            if (string.Equals(value, "Microsoft.KeyVault", StringComparison.InvariantCultureIgnoreCase)) return BatchAccountKeySource.MicrosoftKeyVault;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchAccountKeySource value.");
        }
    }
}
