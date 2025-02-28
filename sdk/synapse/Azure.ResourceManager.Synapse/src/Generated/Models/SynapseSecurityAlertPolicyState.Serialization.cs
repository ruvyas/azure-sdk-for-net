// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Synapse.Models
{
    internal static partial class SynapseSecurityAlertPolicyStateExtensions
    {
        public static string ToSerialString(this SynapseSecurityAlertPolicyState value) => value switch
        {
            SynapseSecurityAlertPolicyState.New => "New",
            SynapseSecurityAlertPolicyState.Enabled => "Enabled",
            SynapseSecurityAlertPolicyState.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SynapseSecurityAlertPolicyState value.")
        };

        public static SynapseSecurityAlertPolicyState ToSynapseSecurityAlertPolicyState(this string value)
        {
            if (string.Equals(value, "New", StringComparison.InvariantCultureIgnoreCase)) return SynapseSecurityAlertPolicyState.New;
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return SynapseSecurityAlertPolicyState.Enabled;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return SynapseSecurityAlertPolicyState.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SynapseSecurityAlertPolicyState value.");
        }
    }
}
