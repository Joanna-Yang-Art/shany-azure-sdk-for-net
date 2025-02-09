// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Defines the common match conditions of the ACL and Network Tap Rule. </summary>
    public partial class CommonMatchConditions
    {
        /// <summary> Initializes a new instance of CommonMatchConditions. </summary>
        public CommonMatchConditions()
        {
            ProtocolTypes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CommonMatchConditions. </summary>
        /// <param name="protocolTypes"> List of the protocols that need to be matched. </param>
        /// <param name="vlanMatchCondition"> Vlan match condition that needs to be matched. </param>
        /// <param name="ipCondition"> IP condition that needs to be matched. </param>
        internal CommonMatchConditions(IList<string> protocolTypes, VlanMatchCondition vlanMatchCondition, IPMatchCondition ipCondition)
        {
            ProtocolTypes = protocolTypes;
            VlanMatchCondition = vlanMatchCondition;
            IPCondition = ipCondition;
        }

        /// <summary> List of the protocols that need to be matched. </summary>
        public IList<string> ProtocolTypes { get; }
        /// <summary> Vlan match condition that needs to be matched. </summary>
        public VlanMatchCondition VlanMatchCondition { get; set; }
        /// <summary> IP condition that needs to be matched. </summary>
        public IPMatchCondition IPCondition { get; set; }
    }
}
