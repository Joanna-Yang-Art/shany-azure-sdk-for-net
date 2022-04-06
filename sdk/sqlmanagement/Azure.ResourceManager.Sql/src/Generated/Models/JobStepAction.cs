// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The action to be executed by a job step. </summary>
    public partial class JobStepAction
    {
        /// <summary> Initializes a new instance of JobStepAction. </summary>
        /// <param name="value"> The action value, for example the text of the T-SQL script to execute. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobStepAction(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }

        /// <summary> Initializes a new instance of JobStepAction. </summary>
        /// <param name="actionType"> Type of action being executed by the job step. </param>
        /// <param name="source"> The source of the action to execute. </param>
        /// <param name="value"> The action value, for example the text of the T-SQL script to execute. </param>
        internal JobStepAction(JobStepActionType? actionType, JobStepActionSource? source, string value)
        {
            ActionType = actionType;
            Source = source;
            Value = value;
        }

        /// <summary> Type of action being executed by the job step. </summary>
        public JobStepActionType? ActionType { get; set; }
        /// <summary> The source of the action to execute. </summary>
        public JobStepActionSource? Source { get; set; }
        /// <summary> The action value, for example the text of the T-SQL script to execute. </summary>
        public string Value { get; set; }
    }
}
