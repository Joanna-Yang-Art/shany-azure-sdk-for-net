// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    internal class GitOperationResultContractDataOperationSource : IOperationSource<GitOperationResultContractData>
    {
        GitOperationResultContractData IOperationSource<GitOperationResultContractData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return GitOperationResultContractData.DeserializeGitOperationResultContractData(document.RootElement);
        }

        async ValueTask<GitOperationResultContractData> IOperationSource<GitOperationResultContractData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return GitOperationResultContractData.DeserializeGitOperationResultContractData(document.RootElement);
        }
    }
}
