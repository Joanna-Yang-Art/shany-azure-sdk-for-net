// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class AddParticipantsRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceCallerId))
            {
                writer.WritePropertyName("sourceCallerId");
                writer.WriteObjectValue(SourceCallerId);
            }
            writer.WritePropertyName("participantsToAdd");
            writer.WriteStartArray();
            foreach (var item in ParticipantsToAdd)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(InvitationTimeoutInSeconds))
            {
                writer.WritePropertyName("invitationTimeoutInSeconds");
                writer.WriteNumberValue(InvitationTimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(ReplacementCallConnectionId))
            {
                writer.WritePropertyName("replacementCallConnectionId");
                writer.WriteStringValue(ReplacementCallConnectionId);
            }
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext");
                writer.WriteStringValue(OperationContext);
            }
            writer.WriteEndObject();
        }
    }
}
