// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Parameters supplied to the CreateOrUpdate NotificationHub operation. </summary>
    public partial class NotificationHubCreateOrUpdateContent : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NotificationHubCreateOrUpdateContent. </summary>
        /// <param name="location"> The location. </param>
        public NotificationHubCreateOrUpdateContent(AzureLocation location) : base(location)
        {
            AuthorizationRules = new ChangeTrackingList<SharedAccessAuthorizationRuleProperties>();
        }

        /// <summary> Initializes a new instance of NotificationHubCreateOrUpdateContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="notificationHubName"> The NotificationHub name. </param>
        /// <param name="registrationTtl"> The RegistrationTtl of the created NotificationHub. </param>
        /// <param name="authorizationRules"> The AuthorizationRules of the created NotificationHub. </param>
        /// <param name="apnsCredential"> The ApnsCredential of the created NotificationHub. </param>
        /// <param name="wnsCredential"> The WnsCredential of the created NotificationHub. </param>
        /// <param name="gcmCredential"> The GcmCredential of the created NotificationHub. </param>
        /// <param name="mpnsCredential"> The MpnsCredential of the created NotificationHub. </param>
        /// <param name="admCredential"> The AdmCredential of the created NotificationHub. </param>
        /// <param name="baiduCredential"> The BaiduCredential of the created NotificationHub. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        internal NotificationHubCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string notificationHubName, TimeSpan? registrationTtl, IList<SharedAccessAuthorizationRuleProperties> authorizationRules, NotificationHubApnsCredential apnsCredential, NotificationHubWnsCredential wnsCredential, NotificationHubGcmCredential gcmCredential, NotificationHubMpnsCredential mpnsCredential, NotificationHubAdmCredential admCredential, NotificationHubBaiduCredential baiduCredential, NotificationHubSku sku) : base(id, name, resourceType, systemData, tags, location)
        {
            NotificationHubName = notificationHubName;
            RegistrationTtl = registrationTtl;
            AuthorizationRules = authorizationRules;
            ApnsCredential = apnsCredential;
            WnsCredential = wnsCredential;
            GcmCredential = gcmCredential;
            MpnsCredential = mpnsCredential;
            AdmCredential = admCredential;
            BaiduCredential = baiduCredential;
            Sku = sku;
        }

        /// <summary> The NotificationHub name. </summary>
        public string NotificationHubName { get; set; }
        /// <summary> The RegistrationTtl of the created NotificationHub. </summary>
        public TimeSpan? RegistrationTtl { get; set; }
        /// <summary> The AuthorizationRules of the created NotificationHub. </summary>
        public IList<SharedAccessAuthorizationRuleProperties> AuthorizationRules { get; }
        /// <summary> The ApnsCredential of the created NotificationHub. </summary>
        public NotificationHubApnsCredential ApnsCredential { get; set; }
        /// <summary> The WnsCredential of the created NotificationHub. </summary>
        public NotificationHubWnsCredential WnsCredential { get; set; }
        /// <summary> The GcmCredential of the created NotificationHub. </summary>
        public NotificationHubGcmCredential GcmCredential { get; set; }
        /// <summary> The MpnsCredential of the created NotificationHub. </summary>
        public NotificationHubMpnsCredential MpnsCredential { get; set; }
        /// <summary> The AdmCredential of the created NotificationHub. </summary>
        public NotificationHubAdmCredential AdmCredential { get; set; }
        /// <summary> The BaiduCredential of the created NotificationHub. </summary>
        public NotificationHubBaiduCredential BaiduCredential { get; set; }
        /// <summary> The sku of the created namespace. </summary>
        public NotificationHubSku Sku { get; set; }
    }
}
