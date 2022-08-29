// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A Class representing an ArmTemplate along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="ArmTemplateResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetArmTemplateResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArtifactSourceResource" /> using the GetArmTemplate method.
    /// </summary>
    public partial class ArmTemplateResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ArmTemplateResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string labName, string artifactSourceName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{artifactSourceName}/armtemplates/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _armTemplateClientDiagnostics;
        private readonly ArmTemplatesRestOperations _armTemplateRestClient;
        private readonly ArmTemplateData _data;

        /// <summary> Initializes a new instance of the <see cref="ArmTemplateResource"/> class for mocking. </summary>
        protected ArmTemplateResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ArmTemplateResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ArmTemplateResource(ArmClient client, ArmTemplateData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ArmTemplateResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ArmTemplateResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _armTemplateClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string armTemplateApiVersion);
            _armTemplateRestClient = new ArmTemplatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, armTemplateApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DevTestLab/labs/artifactsources/armtemplates";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ArmTemplateData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get azure resource manager template.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{artifactSourceName}/armtemplates/{name}
        /// Operation Id: ArmTemplates_Get
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=displayName)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ArmTemplateResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _armTemplateClientDiagnostics.CreateScope("ArmTemplateResource.Get");
            scope.Start();
            try
            {
                var response = await _armTemplateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArmTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get azure resource manager template.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/artifactsources/{artifactSourceName}/armtemplates/{name}
        /// Operation Id: ArmTemplates_Get
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=displayName)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ArmTemplateResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _armTemplateClientDiagnostics.CreateScope("ArmTemplateResource.Get");
            scope.Start();
            try
            {
                var response = _armTemplateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArmTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
