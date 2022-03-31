// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing the LogSearchRule data model. </summary>
    public partial class LogSearchRuleData : ResourceAutoGenerated
    {
        /// <summary> Initializes a new instance of LogSearchRuleData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="source"> Data Source against which rule will Query Data. </param>
        /// <param name="action"> Action needs to be taken on rule execution. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> or <paramref name="action"/> is null. </exception>
        public LogSearchRuleData(AzureLocation location, MonitorSource source, MonitorAction action) : base(location)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            Source = source;
            Action = action;
        }

        /// <summary> Initializes a new instance of LogSearchRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="etag"> The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </param>
        /// <param name="createdWithApiVersion"> The api-version used when creating this alert rule. </param>
        /// <param name="isLegacyLogAnalyticsRule"> True if alert rule is legacy Log Analytic rule. </param>
        /// <param name="description"> The description of the Log Search rule. </param>
        /// <param name="displayName"> The display name of the alert rule. </param>
        /// <param name="autoMitigate"> The flag that indicates whether the alert should be automatically resolved or not. The default is false. </param>
        /// <param name="enabled"> The flag which indicates whether the Log Search rule is enabled. Value should be true or false. </param>
        /// <param name="lastUpdatedTime"> Last time the rule was updated in IS08601 format. </param>
        /// <param name="provisioningState"> Provisioning state of the scheduled query rule. </param>
        /// <param name="source"> Data Source against which rule will Query Data. </param>
        /// <param name="schedule"> Schedule (Frequency, Time Window) for rule. Required for action type - AlertingAction. </param>
        /// <param name="action"> Action needs to be taken on rule execution. </param>
        internal LogSearchRuleData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string kind, string etag, string createdWithApiVersion, bool? isLegacyLogAnalyticsRule, string description, string displayName, bool? autoMitigate, Enabled? enabled, DateTimeOffset? lastUpdatedTime, ProvisioningState? provisioningState, MonitorSource source, MonitorSchedule schedule, MonitorAction action) : base(id, name, type, systemData, tags, location, kind, etag)
        {
            CreatedWithApiVersion = createdWithApiVersion;
            IsLegacyLogAnalyticsRule = isLegacyLogAnalyticsRule;
            Description = description;
            DisplayName = displayName;
            AutoMitigate = autoMitigate;
            Enabled = enabled;
            LastUpdatedTime = lastUpdatedTime;
            ProvisioningState = provisioningState;
            Source = source;
            Schedule = schedule;
            Action = action;
        }

        /// <summary> The api-version used when creating this alert rule. </summary>
        public string CreatedWithApiVersion { get; }
        /// <summary> True if alert rule is legacy Log Analytic rule. </summary>
        public bool? IsLegacyLogAnalyticsRule { get; }
        /// <summary> The description of the Log Search rule. </summary>
        public string Description { get; set; }
        /// <summary> The display name of the alert rule. </summary>
        public string DisplayName { get; set; }
        /// <summary> The flag that indicates whether the alert should be automatically resolved or not. The default is false. </summary>
        public bool? AutoMitigate { get; set; }
        /// <summary> The flag which indicates whether the Log Search rule is enabled. Value should be true or false. </summary>
        public Enabled? Enabled { get; set; }
        /// <summary> Last time the rule was updated in IS08601 format. </summary>
        public DateTimeOffset? LastUpdatedTime { get; }
        /// <summary> Provisioning state of the scheduled query rule. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Data Source against which rule will Query Data. </summary>
        public MonitorSource Source { get; set; }
        /// <summary> Schedule (Frequency, Time Window) for rule. Required for action type - AlertingAction. </summary>
        public MonitorSchedule Schedule { get; set; }
        /// <summary> Action needs to be taken on rule execution. </summary>
        public MonitorAction Action { get; set; }
    }
}
