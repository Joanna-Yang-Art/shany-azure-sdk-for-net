// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> storage edition capability. </summary>
    public partial class PostgreSqlFlexibleServerStorageEditionCapability
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerStorageEditionCapability. </summary>
        internal PostgreSqlFlexibleServerStorageEditionCapability()
        {
            SupportedStorageCapabilities = new ChangeTrackingList<PostgreSqlFlexibleServerStorageCapability>();
        }

        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerStorageEditionCapability. </summary>
        /// <param name="name"> storage edition name. </param>
        /// <param name="supportedStorageCapabilities"></param>
        /// <param name="status"> The status. </param>
        internal PostgreSqlFlexibleServerStorageEditionCapability(string name, IReadOnlyList<PostgreSqlFlexibleServerStorageCapability> supportedStorageCapabilities, string status)
        {
            Name = name;
            SupportedStorageCapabilities = supportedStorageCapabilities;
            Status = status;
        }

        /// <summary> storage edition name. </summary>
        public string Name { get; }
        /// <summary> Gets the supported storage capabilities. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerStorageCapability> SupportedStorageCapabilities { get; }
        /// <summary> The status. </summary>
        public string Status { get; }
    }
}
