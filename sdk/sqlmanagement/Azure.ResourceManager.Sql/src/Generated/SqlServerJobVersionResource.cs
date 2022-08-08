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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SqlServerJobVersion along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SqlServerJobVersionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSqlServerJobVersionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerJobResource" /> using the GetSqlServerJobVersion method.
    /// </summary>
    public partial class SqlServerJobVersionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlServerJobVersionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, int jobVersion)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlServerJobVersionJobVersionsClientDiagnostics;
        private readonly JobVersionsRestOperations _sqlServerJobVersionJobVersionsRestClient;
        private readonly SqlServerJobVersionData _data;

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobVersionResource"/> class for mocking. </summary>
        protected SqlServerJobVersionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlServerJobVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlServerJobVersionResource(ArmClient client, SqlServerJobVersionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerJobVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlServerJobVersionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerJobVersionJobVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlServerJobVersionJobVersionsApiVersion);
            _sqlServerJobVersionJobVersionsRestClient = new JobVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerJobVersionJobVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/jobAgents/jobs/versions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlServerJobVersionData Data
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

        /// <summary> Gets a collection of SqlServerJobVersionStepResources in the SqlServerJobVersion. </summary>
        /// <returns> An object representing collection of SqlServerJobVersionStepResources and their operations over a SqlServerJobVersionStepResource. </returns>
        public virtual SqlServerJobVersionStepCollection GetSqlServerJobVersionSteps()
        {
            return GetCachedClient(Client => new SqlServerJobVersionStepCollection(Client, Id));
        }

        /// <summary>
        /// Gets the specified version of a job step.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps/{stepName}
        /// Operation Id: JobSteps_GetByVersion
        /// </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SqlServerJobVersionStepResource>> GetSqlServerJobVersionStepAsync(string stepName, CancellationToken cancellationToken = default)
        {
            return await GetSqlServerJobVersionSteps().GetAsync(stepName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified version of a job step.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}/steps/{stepName}
        /// Operation Id: JobSteps_GetByVersion
        /// </summary>
        /// <param name="stepName"> The name of the job step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<SqlServerJobVersionStepResource> GetSqlServerJobVersionStep(string stepName, CancellationToken cancellationToken = default)
        {
            return GetSqlServerJobVersionSteps().Get(stepName, cancellationToken);
        }

        /// <summary>
        /// Gets a job version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}
        /// Operation Id: JobVersions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerJobVersionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobVersionJobVersionsClientDiagnostics.CreateScope("SqlServerJobVersionResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerJobVersionJobVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a job version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}
        /// Operation Id: JobVersions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerJobVersionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerJobVersionJobVersionsClientDiagnostics.CreateScope("SqlServerJobVersionResource.Get");
            scope.Start();
            try
            {
                var response = _sqlServerJobVersionJobVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, int.Parse(Id.Name), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerJobVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
