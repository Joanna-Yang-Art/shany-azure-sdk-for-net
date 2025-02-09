// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    /// <summary> A group to be updated. </summary>
    public partial class ContainerServiceFleetUpdateGroup
    {
        /// <summary> Initializes a new instance of ContainerServiceFleetUpdateGroup. </summary>
        /// <param name="name">
        /// Name of the group.
        /// It must match a group name of an existing fleet member.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ContainerServiceFleetUpdateGroup(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary>
        /// Name of the group.
        /// It must match a group name of an existing fleet member.
        /// </summary>
        public string Name { get; set; }
    }
}
