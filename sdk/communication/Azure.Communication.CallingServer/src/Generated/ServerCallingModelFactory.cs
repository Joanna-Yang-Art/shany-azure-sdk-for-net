// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class ServerCallingModelFactory
    {
        /// <summary> Initializes a new instance of AnswerCallResponse. </summary>
        /// <param name="serverCallId"> The server call id. </param>
        /// <param name="callConnectionId"> The subscription id. </param>
        /// <returns> A new <see cref="CallingServer.AnswerCallResponse"/> instance for mocking. </returns>
        public static AnswerCallResponse AnswerCallResponse(string serverCallId = null, string callConnectionId = null)
        {
            return new AnswerCallResponse(serverCallId, callConnectionId);
        }

        /// <summary> Initializes a new instance of TransferCallResponse. </summary>
        /// <param name="operationId"> The operation id. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <param name="resultDetails"> The result info for the operation. </param>
        /// <returns> A new <see cref="CallingServer.TransferCallResponse"/> instance for mocking. </returns>
        public static TransferCallResponse TransferCallResponse(string operationId = null, CallingOperationStatusDto status = default, string operationContext = null, CallingOperationResultDetailsDto resultDetails = null)
        {
            return new TransferCallResponse(operationId, status, operationContext, resultDetails);
        }

        /// <summary> Initializes a new instance of CallingOperationResultDetailsDto. </summary>
        /// <param name="code"> The result code associated with the operation. </param>
        /// <param name="subcode"> The subcode that further classifies the result. </param>
        /// <param name="message"> The message is a detail explanation of subcode. </param>
        /// <returns> A new <see cref="CallingServer.CallingOperationResultDetailsDto"/> instance for mocking. </returns>
        public static CallingOperationResultDetailsDto CallingOperationResultDetailsDto(int code = default, int subcode = default, string message = null)
        {
            return new CallingOperationResultDetailsDto(code, subcode, message);
        }

        /// <summary> Initializes a new instance of AddParticipantsResponse. </summary>
        /// <param name="operationId"> The operation id. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <param name="resultDetails"> The result info for the operation. </param>
        /// <returns> A new <see cref="CallingServer.AddParticipantsResponse"/> instance for mocking. </returns>
        public static AddParticipantsResponse AddParticipantsResponse(string operationId = null, CallingOperationStatusDto status = default, string operationContext = null, CallingOperationResultDetailsDto resultDetails = null)
        {
            return new AddParticipantsResponse(operationId, status, operationContext, resultDetails);
        }

        /// <summary> Initializes a new instance of RemoveParticipantsResponse. </summary>
        /// <param name="operationId"> The operation id. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <param name="resultDetails"> The result info for the operation. </param>
        /// <returns> A new <see cref="CallingServer.RemoveParticipantsResponse"/> instance for mocking. </returns>
        public static RemoveParticipantsResponse RemoveParticipantsResponse(string operationId = null, CallingOperationStatusDto status = default, string operationContext = null, CallingOperationResultDetailsDto resultDetails = null)
        {
            return new RemoveParticipantsResponse(operationId, status, operationContext, resultDetails);
        }
    }
}
