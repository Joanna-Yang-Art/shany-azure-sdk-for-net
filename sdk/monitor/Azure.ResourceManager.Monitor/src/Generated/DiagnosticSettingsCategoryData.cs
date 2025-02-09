// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing the DiagnosticSettingsCategory data model.
    /// The diagnostic settings category resource.
    /// </summary>
    public partial class DiagnosticSettingsCategoryData : ResourceData
    {
        /// <summary> Initializes a new instance of DiagnosticSettingsCategoryData. </summary>
        public DiagnosticSettingsCategoryData()
        {
            CategoryGroups = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DiagnosticSettingsCategoryData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="categoryType"> The type of the diagnostic settings category. </param>
        /// <param name="categoryGroups"> the collection of what category groups are supported. </param>
        internal DiagnosticSettingsCategoryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MonitorCategoryType? categoryType, IList<string> categoryGroups) : base(id, name, resourceType, systemData)
        {
            CategoryType = categoryType;
            CategoryGroups = categoryGroups;
        }

        /// <summary> The type of the diagnostic settings category. </summary>
        public MonitorCategoryType? CategoryType { get; set; }
        /// <summary> the collection of what category groups are supported. </summary>
        public IList<string> CategoryGroups { get; }
    }
}
