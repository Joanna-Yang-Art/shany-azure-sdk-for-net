// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Network security rule.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SecurityRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the SecurityRule class.
        /// </summary>
        public SecurityRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityRule class.
        /// </summary>
        /// <param name="protocol">Network protocol this rule applies to.
        /// Possible values include: 'Tcp', 'Udp', 'Icmp', 'Esp', '*'</param>
        /// <param name="access">The network traffic is allowed or denied.
        /// Possible values include: 'Allow', 'Deny'</param>
        /// <param name="direction">The direction of the rule. The direction
        /// specifies if rule will be evaluated on incoming or outgoing
        /// traffic. Possible values include: 'Inbound', 'Outbound'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="description">A description for this rule. Restricted
        /// to 140 chars.</param>
        /// <param name="sourcePortRange">The source port or range. Integer or
        /// range between 0 and 65535. Asterisk '*' can also be used to match
        /// all ports.</param>
        /// <param name="destinationPortRange">The destination port or range.
        /// Integer or range between 0 and 65535. Asterisk '*' can also be used
        /// to match all ports.</param>
        /// <param name="sourceAddressPrefix">The CIDR or source IP range.
        /// Asterisk '*' can also be used to match all source IPs. Default tags
        /// such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can
        /// also be used. If this is an ingress rule, specifies where network
        /// traffic originates from.</param>
        /// <param name="sourceAddressPrefixes">The CIDR or source IP
        /// ranges.</param>
        /// <param name="sourceApplicationSecurityGroups">The application
        /// security group specified as source.</param>
        /// <param name="destinationAddressPrefix">The destination address
        /// prefix. CIDR or destination IP range. Asterisk '*' can also be used
        /// to match all source IPs. Default tags such as 'VirtualNetwork',
        /// 'AzureLoadBalancer' and 'Internet' can also be used.</param>
        /// <param name="destinationAddressPrefixes">The destination address
        /// prefixes. CIDR or destination IP ranges.</param>
        /// <param name="destinationApplicationSecurityGroups">The application
        /// security group specified as destination.</param>
        /// <param name="sourcePortRanges">The source port ranges.</param>
        /// <param name="destinationPortRanges">The destination port
        /// ranges.</param>
        /// <param name="priority">The priority of the rule. The value can be
        /// between 100 and 4096. The priority number must be unique for each
        /// rule in the collection. The lower the priority number, the higher
        /// the priority of the rule.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// public IP resource. Possible values are: 'Updating', 'Deleting',
        /// and 'Failed'.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public SecurityRule(string protocol, string access, string direction, string id = default(string), string description = default(string), string sourcePortRange = default(string), string destinationPortRange = default(string), string sourceAddressPrefix = default(string), IList<string> sourceAddressPrefixes = default(IList<string>), IList<ApplicationSecurityGroup> sourceApplicationSecurityGroups = default(IList<ApplicationSecurityGroup>), string destinationAddressPrefix = default(string), IList<string> destinationAddressPrefixes = default(IList<string>), IList<ApplicationSecurityGroup> destinationApplicationSecurityGroups = default(IList<ApplicationSecurityGroup>), IList<string> sourcePortRanges = default(IList<string>), IList<string> destinationPortRanges = default(IList<string>), int? priority = default(int?), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            Description = description;
            Protocol = protocol;
            SourcePortRange = sourcePortRange;
            DestinationPortRange = destinationPortRange;
            SourceAddressPrefix = sourceAddressPrefix;
            SourceAddressPrefixes = sourceAddressPrefixes;
            SourceApplicationSecurityGroups = sourceApplicationSecurityGroups;
            DestinationAddressPrefix = destinationAddressPrefix;
            DestinationAddressPrefixes = destinationAddressPrefixes;
            DestinationApplicationSecurityGroups = destinationApplicationSecurityGroups;
            SourcePortRanges = sourcePortRanges;
            DestinationPortRanges = destinationPortRanges;
            Access = access;
            Priority = priority;
            Direction = direction;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a description for this rule. Restricted to 140 chars.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets network protocol this rule applies to. Possible values
        /// include: 'Tcp', 'Udp', 'Icmp', 'Esp', '*'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the source port or range. Integer or range between 0
        /// and 65535. Asterisk '*' can also be used to match all ports.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourcePortRange")]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// Gets or sets the destination port or range. Integer or range
        /// between 0 and 65535. Asterisk '*' can also be used to match all
        /// ports.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinationPortRange")]
        public string DestinationPortRange { get; set; }

        /// <summary>
        /// Gets or sets the CIDR or source IP range. Asterisk '*' can also be
        /// used to match all source IPs. Default tags such as
        /// 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be
        /// used. If this is an ingress rule, specifies where network traffic
        /// originates from.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceAddressPrefix")]
        public string SourceAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the CIDR or source IP ranges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceAddressPrefixes")]
        public IList<string> SourceAddressPrefixes { get; set; }

        /// <summary>
        /// Gets or sets the application security group specified as source.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceApplicationSecurityGroups")]
        public IList<ApplicationSecurityGroup> SourceApplicationSecurityGroups { get; set; }

        /// <summary>
        /// Gets or sets the destination address prefix. CIDR or destination IP
        /// range. Asterisk '*' can also be used to match all source IPs.
        /// Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and
        /// 'Internet' can also be used.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinationAddressPrefix")]
        public string DestinationAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the destination address prefixes. CIDR or destination
        /// IP ranges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinationAddressPrefixes")]
        public IList<string> DestinationAddressPrefixes { get; set; }

        /// <summary>
        /// Gets or sets the application security group specified as
        /// destination.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinationApplicationSecurityGroups")]
        public IList<ApplicationSecurityGroup> DestinationApplicationSecurityGroups { get; set; }

        /// <summary>
        /// Gets or sets the source port ranges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourcePortRanges")]
        public IList<string> SourcePortRanges { get; set; }

        /// <summary>
        /// Gets or sets the destination port ranges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinationPortRanges")]
        public IList<string> DestinationPortRanges { get; set; }

        /// <summary>
        /// Gets or sets the network traffic is allowed or denied. Possible
        /// values include: 'Allow', 'Deny'
        /// </summary>
        [JsonProperty(PropertyName = "properties.access")]
        public string Access { get; set; }

        /// <summary>
        /// Gets or sets the priority of the rule. The value can be between 100
        /// and 4096. The priority number must be unique for each rule in the
        /// collection. The lower the priority number, the higher the priority
        /// of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the direction of the rule. The direction specifies if
        /// rule will be evaluated on incoming or outgoing traffic. Possible
        /// values include: 'Inbound', 'Outbound'
        /// </summary>
        [JsonProperty(PropertyName = "properties.direction")]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the public IP resource.
        /// Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Protocol == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Protocol");
            }
            if (Access == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Access");
            }
            if (Direction == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Direction");
            }
        }
    }
}
