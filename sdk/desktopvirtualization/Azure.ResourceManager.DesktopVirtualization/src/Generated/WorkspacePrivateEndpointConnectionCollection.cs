// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing a collection of <see cref="WorkspacePrivateEndpointConnectionResource" /> and their operations.
    /// Each <see cref="WorkspacePrivateEndpointConnectionResource" /> in the collection will belong to the same instance of <see cref="VirtualWorkspaceResource" />.
    /// To get a <see cref="WorkspacePrivateEndpointConnectionCollection" /> instance call the GetWorkspacePrivateEndpointConnections method from an instance of <see cref="VirtualWorkspaceResource" />.
    /// </summary>
    public partial class WorkspacePrivateEndpointConnectionCollection : ArmCollection, IEnumerable<WorkspacePrivateEndpointConnectionResource>, IAsyncEnumerable<WorkspacePrivateEndpointConnectionResource>
    {
        private readonly ClientDiagnostics _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics;
        private readonly PrivateEndpointConnectionsRestOperations _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkspacePrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected WorkspacePrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkspacePrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkspacePrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", WorkspacePrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkspacePrivateEndpointConnectionResource.ResourceType, out string workspacePrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
            _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient = new PrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workspacePrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Approve or reject a private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_UpdateByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="connection"> Object containing the updated connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="connection"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkspacePrivateEndpointConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointConnectionName, DesktopVirtualizationPrivateEndpointConnection connection, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(connection, nameof(connection));

            using var scope = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("WorkspacePrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.UpdateByWorkspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, connection, cancellationToken).ConfigureAwait(false);
                var operation = new DesktopVirtualizationArmOperation<WorkspacePrivateEndpointConnectionResource>(Response.FromValue(new WorkspacePrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Approve or reject a private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_UpdateByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="connection"> Object containing the updated connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="connection"/> is null. </exception>
        public virtual ArmOperation<WorkspacePrivateEndpointConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointConnectionName, DesktopVirtualizationPrivateEndpointConnection connection, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(connection, nameof(connection));

            using var scope = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("WorkspacePrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.UpdateByWorkspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, connection, cancellationToken);
                var operation = new DesktopVirtualizationArmOperation<WorkspacePrivateEndpointConnectionResource>(Response.FromValue(new WorkspacePrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_GetByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<WorkspacePrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("WorkspacePrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetByWorkspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkspacePrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_GetByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<WorkspacePrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("WorkspacePrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetByWorkspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkspacePrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List private endpoint connections.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkspacePrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkspacePrivateEndpointConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WorkspacePrivateEndpointConnectionResource(Client, DesktopVirtualizationPrivateEndpointConnectionDataData.DeserializeDesktopVirtualizationPrivateEndpointConnectionDataData(e)), _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, "WorkspacePrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List private endpoint connections.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkspacePrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkspacePrivateEndpointConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WorkspacePrivateEndpointConnectionResource(Client, DesktopVirtualizationPrivateEndpointConnectionDataData.DeserializeDesktopVirtualizationPrivateEndpointConnectionDataData(e)), _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, "WorkspacePrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_GetByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("WorkspacePrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetByWorkspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_GetByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("WorkspacePrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetByWorkspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_GetByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<WorkspacePrivateEndpointConnectionResource>> GetIfExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("WorkspacePrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetByWorkspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WorkspacePrivateEndpointConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new WorkspacePrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_GetByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual NullableResponse<WorkspacePrivateEndpointConnectionResource> GetIfExists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("WorkspacePrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetByWorkspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WorkspacePrivateEndpointConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new WorkspacePrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkspacePrivateEndpointConnectionResource> IEnumerable<WorkspacePrivateEndpointConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkspacePrivateEndpointConnectionResource> IAsyncEnumerable<WorkspacePrivateEndpointConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
