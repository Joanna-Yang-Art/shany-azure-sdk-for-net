// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> Private IP address allocation method. </summary>
    public readonly partial struct InboundEndpointIPAllocationMethod : IEquatable<InboundEndpointIPAllocationMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InboundEndpointIPAllocationMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InboundEndpointIPAllocationMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StaticValue = "Static";
        private const string DynamicValue = "Dynamic";

        /// <summary> Static. </summary>
        public static InboundEndpointIPAllocationMethod Static { get; } = new InboundEndpointIPAllocationMethod(StaticValue);
        /// <summary> Dynamic. </summary>
        public static InboundEndpointIPAllocationMethod Dynamic { get; } = new InboundEndpointIPAllocationMethod(DynamicValue);
        /// <summary> Determines if two <see cref="InboundEndpointIPAllocationMethod"/> values are the same. </summary>
        public static bool operator ==(InboundEndpointIPAllocationMethod left, InboundEndpointIPAllocationMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InboundEndpointIPAllocationMethod"/> values are not the same. </summary>
        public static bool operator !=(InboundEndpointIPAllocationMethod left, InboundEndpointIPAllocationMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InboundEndpointIPAllocationMethod"/>. </summary>
        public static implicit operator InboundEndpointIPAllocationMethod(string value) => new InboundEndpointIPAllocationMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InboundEndpointIPAllocationMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InboundEndpointIPAllocationMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
