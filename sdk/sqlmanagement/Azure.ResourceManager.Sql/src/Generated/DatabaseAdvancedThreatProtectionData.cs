// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the DatabaseAdvancedThreatProtection data model. </summary>
    public partial class DatabaseAdvancedThreatProtectionData : ResourceData
    {
        /// <summary> Initializes a new instance of DatabaseAdvancedThreatProtectionData. </summary>
        public DatabaseAdvancedThreatProtectionData()
        {
        }

        /// <summary> Initializes a new instance of DatabaseAdvancedThreatProtectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="state"> Specifies the state of the Advanced Threat Protection, whether it is enabled or disabled or a state has not been applied yet on the specific database or server. </param>
        /// <param name="createdOn"> Specifies the UTC creation time of the policy. </param>
        internal DatabaseAdvancedThreatProtectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AdvancedThreatProtectionState? state, DateTimeOffset? createdOn) : base(id, name, resourceType, systemData)
        {
            State = state;
            CreatedOn = createdOn;
        }

        /// <summary> Specifies the state of the Advanced Threat Protection, whether it is enabled or disabled or a state has not been applied yet on the specific database or server. </summary>
        public AdvancedThreatProtectionState? State { get; set; }
        /// <summary> Specifies the UTC creation time of the policy. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}
