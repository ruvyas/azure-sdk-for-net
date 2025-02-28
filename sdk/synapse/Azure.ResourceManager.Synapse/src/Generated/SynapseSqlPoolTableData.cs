// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary> A class representing the SynapseSqlPoolTable data model. </summary>
    public partial class SynapseSqlPoolTableData : ResourceData
    {
        /// <summary> Initializes a new instance of SynapseSqlPoolTableData. </summary>
        public SynapseSqlPoolTableData()
        {
        }

        /// <summary> Initializes a new instance of SynapseSqlPoolTableData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        internal SynapseSqlPoolTableData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData) : base(id, name, resourceType, systemData)
        {
        }
    }
}
