// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> OData page of service objects. </summary>
    internal partial class DataMigrationServiceList
    {
        /// <summary> Initializes a new instance of DataMigrationServiceList. </summary>
        internal DataMigrationServiceList()
        {
            Value = new ChangeTrackingList<DataMigrationServiceData>();
        }

        /// <summary> Initializes a new instance of DataMigrationServiceList. </summary>
        /// <param name="value"> List of services. </param>
        /// <param name="nextLink"> URL to load the next page of services. </param>
        internal DataMigrationServiceList(IReadOnlyList<DataMigrationServiceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of services. </summary>
        public IReadOnlyList<DataMigrationServiceData> Value { get; }
        /// <summary> URL to load the next page of services. </summary>
        public string NextLink { get; }
    }
}
