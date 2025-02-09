// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Individual port mappings for inbound NAT rule created for backend pool. </summary>
    public partial class NatRulePortMapping
    {
        /// <summary> Initializes a new instance of NatRulePortMapping. </summary>
        internal NatRulePortMapping()
        {
        }

        /// <summary> Initializes a new instance of NatRulePortMapping. </summary>
        /// <param name="inboundNatRuleName"> Name of inbound NAT rule. </param>
        /// <param name="frontendPort"> Frontend port. </param>
        /// <param name="backendPort"> Backend port. </param>
        internal NatRulePortMapping(string inboundNatRuleName, int? frontendPort, int? backendPort)
        {
            InboundNatRuleName = inboundNatRuleName;
            FrontendPort = frontendPort;
            BackendPort = backendPort;
        }

        /// <summary> Name of inbound NAT rule. </summary>
        public string InboundNatRuleName { get; }
        /// <summary> Frontend port. </summary>
        public int? FrontendPort { get; }
        /// <summary> Backend port. </summary>
        public int? BackendPort { get; }
    }
}
