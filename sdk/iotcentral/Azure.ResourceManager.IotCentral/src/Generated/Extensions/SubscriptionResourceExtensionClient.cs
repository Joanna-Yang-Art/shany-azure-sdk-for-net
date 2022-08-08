// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.IotCentral.Models;

namespace Azure.ResourceManager.IotCentral
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _iotCentralAppAppsClientDiagnostics;
        private AppsRestOperations _iotCentralAppAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics IotCentralAppAppsClientDiagnostics => _iotCentralAppAppsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.IotCentral", IotCentralAppResource.ResourceType.Namespace, Diagnostics);
        private AppsRestOperations IotCentralAppAppsRestClient => _iotCentralAppAppsRestClient ??= new AppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(IotCentralAppResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Get all IoT Central Applications in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/iotApps
        /// Operation Id: Apps_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotCentralAppResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IotCentralAppResource> GetIotCentralAppsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<IotCentralAppResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = IotCentralAppAppsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetIotCentralApps");
                scope.Start();
                try
                {
                    var response = await IotCentralAppAppsRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IotCentralAppResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<IotCentralAppResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = IotCentralAppAppsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetIotCentralApps");
                scope.Start();
                try
                {
                    var response = await IotCentralAppAppsRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IotCentralAppResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get all IoT Central Applications in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/iotApps
        /// Operation Id: Apps_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotCentralAppResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IotCentralAppResource> GetIotCentralApps(CancellationToken cancellationToken = default)
        {
            Page<IotCentralAppResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = IotCentralAppAppsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetIotCentralApps");
                scope.Start();
                try
                {
                    var response = IotCentralAppAppsRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IotCentralAppResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<IotCentralAppResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = IotCentralAppAppsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetIotCentralApps");
                scope.Start();
                try
                {
                    var response = IotCentralAppAppsRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IotCentralAppResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Check if an IoT Central application name is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/checkNameAvailability
        /// Operation Id: Apps_CheckNameAvailability
        /// </summary>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the IoT Central application to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IotCentralAppNameAvailabilityResponse>> CheckIotCentralAppNameAvailabilityAsync(IotCentralAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = IotCentralAppAppsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckIotCentralAppNameAvailability");
            scope.Start();
            try
            {
                var response = await IotCentralAppAppsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if an IoT Central application name is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/checkNameAvailability
        /// Operation Id: Apps_CheckNameAvailability
        /// </summary>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the IoT Central application to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IotCentralAppNameAvailabilityResponse> CheckIotCentralAppNameAvailability(IotCentralAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = IotCentralAppAppsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckIotCentralAppNameAvailability");
            scope.Start();
            try
            {
                var response = IotCentralAppAppsRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if an IoT Central application subdomain is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/checkSubdomainAvailability
        /// Operation Id: Apps_CheckSubdomainAvailability
        /// </summary>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the subdomain of the IoT Central application to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IotCentralAppNameAvailabilityResponse>> CheckIotCentralAppSubdomainAvailabilityAsync(IotCentralAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = IotCentralAppAppsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckIotCentralAppSubdomainAvailability");
            scope.Start();
            try
            {
                var response = await IotCentralAppAppsRestClient.CheckSubdomainAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if an IoT Central application subdomain is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/checkSubdomainAvailability
        /// Operation Id: Apps_CheckSubdomainAvailability
        /// </summary>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the subdomain of the IoT Central application to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IotCentralAppNameAvailabilityResponse> CheckIotCentralAppSubdomainAvailability(IotCentralAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = IotCentralAppAppsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckIotCentralAppSubdomainAvailability");
            scope.Start();
            try
            {
                var response = IotCentralAppAppsRestClient.CheckSubdomainAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all available application templates.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/appTemplates
        /// Operation Id: Apps_ListTemplates
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotCentralAppTemplate" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IotCentralAppTemplate> GetTemplatesAppsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<IotCentralAppTemplate>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = IotCentralAppAppsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetTemplatesApps");
                scope.Start();
                try
                {
                    var response = await IotCentralAppAppsRestClient.ListTemplatesAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<IotCentralAppTemplate>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = IotCentralAppAppsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetTemplatesApps");
                scope.Start();
                try
                {
                    var response = await IotCentralAppAppsRestClient.ListTemplatesNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get all available application templates.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/appTemplates
        /// Operation Id: Apps_ListTemplates
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotCentralAppTemplate" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IotCentralAppTemplate> GetTemplatesApps(CancellationToken cancellationToken = default)
        {
            Page<IotCentralAppTemplate> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = IotCentralAppAppsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetTemplatesApps");
                scope.Start();
                try
                {
                    var response = IotCentralAppAppsRestClient.ListTemplates(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<IotCentralAppTemplate> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = IotCentralAppAppsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetTemplatesApps");
                scope.Start();
                try
                {
                    var response = IotCentralAppAppsRestClient.ListTemplatesNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
