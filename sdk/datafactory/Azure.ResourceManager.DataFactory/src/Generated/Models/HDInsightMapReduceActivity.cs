// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> HDInsight MapReduce activity type. </summary>
    public partial class HDInsightMapReduceActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of HDInsightMapReduceActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="className"> Class name. Type: string (or Expression with resultType string). </param>
        /// <param name="jarFilePath"> Jar path. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="className"/> or <paramref name="jarFilePath"/> is null. </exception>
        public HDInsightMapReduceActivity(string name, BinaryData className, BinaryData jarFilePath) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (className == null)
            {
                throw new ArgumentNullException(nameof(className));
            }
            if (jarFilePath == null)
            {
                throw new ArgumentNullException(nameof(jarFilePath));
            }

            StorageLinkedServices = new ChangeTrackingList<FactoryLinkedServiceReference>();
            Arguments = new ChangeTrackingList<BinaryData>();
            ClassName = className;
            JarFilePath = jarFilePath;
            JarLibs = new ChangeTrackingList<BinaryData>();
            Defines = new ChangeTrackingDictionary<string, BinaryData>();
            ActivityType = "HDInsightMapReduce";
        }

        /// <summary> Initializes a new instance of HDInsightMapReduceActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="storageLinkedServices"> Storage linked service references. </param>
        /// <param name="arguments"> User specified arguments to HDInsightActivity. </param>
        /// <param name="getDebugInfo"> Debug info option. </param>
        /// <param name="className"> Class name. Type: string (or Expression with resultType string). </param>
        /// <param name="jarFilePath"> Jar path. Type: string (or Expression with resultType string). </param>
        /// <param name="jarLinkedService"> Jar linked service reference. </param>
        /// <param name="jarLibs"> Jar libs. </param>
        /// <param name="defines"> Allows user to specify defines for the MapReduce job request. </param>
        internal HDInsightMapReduceActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, FactoryLinkedServiceReference linkedServiceName, ActivityPolicy policy, IList<FactoryLinkedServiceReference> storageLinkedServices, IList<BinaryData> arguments, HDInsightActivityDebugInfoOptionSetting? getDebugInfo, BinaryData className, BinaryData jarFilePath, FactoryLinkedServiceReference jarLinkedService, IList<BinaryData> jarLibs, IDictionary<string, BinaryData> defines) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            StorageLinkedServices = storageLinkedServices;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            ClassName = className;
            JarFilePath = jarFilePath;
            JarLinkedService = jarLinkedService;
            JarLibs = jarLibs;
            Defines = defines;
            ActivityType = activityType ?? "HDInsightMapReduce";
        }

        /// <summary> Storage linked service references. </summary>
        public IList<FactoryLinkedServiceReference> StorageLinkedServices { get; }
        /// <summary> User specified arguments to HDInsightActivity. </summary>
        public IList<BinaryData> Arguments { get; }
        /// <summary> Debug info option. </summary>
        public HDInsightActivityDebugInfoOptionSetting? GetDebugInfo { get; set; }
        /// <summary> Class name. Type: string (or Expression with resultType string). </summary>
        public BinaryData ClassName { get; set; }
        /// <summary> Jar path. Type: string (or Expression with resultType string). </summary>
        public BinaryData JarFilePath { get; set; }
        /// <summary> Jar linked service reference. </summary>
        public FactoryLinkedServiceReference JarLinkedService { get; set; }
        /// <summary> Jar libs. </summary>
        public IList<BinaryData> JarLibs { get; }
        /// <summary> Allows user to specify defines for the MapReduce job request. </summary>
        public IDictionary<string, BinaryData> Defines { get; }
    }
}
