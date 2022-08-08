// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public readonly partial struct StorageMinimumTlsVersion
    {
#pragma warning disable CA1707

        /// <summary> TLS1_0. </summary>
        [CodeGenMember("TLS10")]
        public static StorageMinimumTlsVersion Tls1_0 { get; } = new StorageMinimumTlsVersion(Tls1_0Value);
        /// <summary> TLS1_1. </summary>
        [CodeGenMember("TLS11")]
        public static StorageMinimumTlsVersion Tls1_1 { get; } = new StorageMinimumTlsVersion(Tls1_1Value);
        /// <summary> TLS1_2. </summary>
        [CodeGenMember("TLS12")]
        public static StorageMinimumTlsVersion Tls1_2 { get; } = new StorageMinimumTlsVersion(Tls1_2Value);
#pragma warning restore CA1707
    }
}
