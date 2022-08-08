// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RedisEnterpriseCache;

namespace Azure.ResourceManager.RedisEnterpriseCache.Models
{
    /// <summary> A partial update to the RedisEnterprise cluster. </summary>
    public partial class RedisEnterpriseClusterPatch
    {
        /// <summary> Initializes a new instance of RedisEnterpriseClusterPatch. </summary>
        public RedisEnterpriseClusterPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            PrivateEndpointConnections = new ChangeTrackingList<RedisEnterprisePrivateEndpointConnectionData>();
        }

        /// <summary> The SKU to create, which affects price, performance, and features. </summary>
        public RedisEnterpriseSku Sku { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The minimum TLS version for the cluster to support, e.g. &apos;1.2&apos;. </summary>
        public RedisEnterpriseTlsVersion? MinimumTlsVersion { get; set; }
        /// <summary> DNS name of the cluster endpoint. </summary>
        public string HostName { get; }
        /// <summary> Current provisioning status of the cluster. </summary>
        public RedisEnterpriseProvisioningStatus? ProvisioningState { get; }
        /// <summary> Current resource status of the cluster. </summary>
        public RedisEnterpriseClusterResourceState? ResourceState { get; }
        /// <summary> Version of redis the cluster supports, e.g. &apos;6&apos;. </summary>
        public string RedisVersion { get; }
        /// <summary> List of private endpoint connections associated with the specified RedisEnterprise cluster. </summary>
        public IReadOnlyList<RedisEnterprisePrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}
