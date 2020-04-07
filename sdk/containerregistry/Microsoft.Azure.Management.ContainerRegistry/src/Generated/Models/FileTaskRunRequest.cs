// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The request parameters for a scheduling run against a task file.
    /// </summary>
    [Newtonsoft.Json.JsonObject("FileTaskRunRequest")]
    public partial class FileTaskRunRequest : RunRequest
    {
        /// <summary>
        /// Initializes a new instance of the FileTaskRunRequest class.
        /// </summary>
        public FileTaskRunRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileTaskRunRequest class.
        /// </summary>
        /// <param name="taskFilePath">The template/definition file path
        /// relative to the source.</param>
        /// <param name="platform">The platform properties against which the
        /// run has to happen.</param>
        /// <param name="isArchiveEnabled">The value that indicates whether
        /// archiving is enabled for the run or not.</param>
        /// <param name="agentPoolName">The dedicated agent pool for the
        /// run.</param>
        /// <param name="valuesFilePath">The values/parameters file path
        /// relative to the source.</param>
        /// <param name="values">The collection of overridable values that can
        /// be passed when running a task.</param>
        /// <param name="timeout">Run timeout in seconds.</param>
        /// <param name="agentConfiguration">The machine configuration of the
        /// run agent.</param>
        /// <param name="sourceLocation">The URL(absolute or relative) of the
        /// source context. It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from
        /// calling listBuildSourceUploadUrl API.</param>
        /// <param name="credentials">The properties that describes a set of
        /// credentials that will be used when this run is invoked.</param>
        public FileTaskRunRequest(string taskFilePath, PlatformProperties platform, bool? isArchiveEnabled = default(bool?), string agentPoolName = default(string), string valuesFilePath = default(string), IList<SetValue> values = default(IList<SetValue>), int? timeout = default(int?), AgentProperties agentConfiguration = default(AgentProperties), string sourceLocation = default(string), Credentials credentials = default(Credentials))
            : base(isArchiveEnabled, agentPoolName)
        {
            TaskFilePath = taskFilePath;
            ValuesFilePath = valuesFilePath;
            Values = values;
            Timeout = timeout;
            Platform = platform;
            AgentConfiguration = agentConfiguration;
            SourceLocation = sourceLocation;
            Credentials = credentials;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the template/definition file path relative to the
        /// source.
        /// </summary>
        [JsonProperty(PropertyName = "taskFilePath")]
        public string TaskFilePath { get; set; }

        /// <summary>
        /// Gets or sets the values/parameters file path relative to the
        /// source.
        /// </summary>
        [JsonProperty(PropertyName = "valuesFilePath")]
        public string ValuesFilePath { get; set; }

        /// <summary>
        /// Gets or sets the collection of overridable values that can be
        /// passed when running a task.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<SetValue> Values { get; set; }

        /// <summary>
        /// Gets or sets run timeout in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Gets or sets the platform properties against which the run has to
        /// happen.
        /// </summary>
        [JsonProperty(PropertyName = "platform")]
        public PlatformProperties Platform { get; set; }

        /// <summary>
        /// Gets or sets the machine configuration of the run agent.
        /// </summary>
        [JsonProperty(PropertyName = "agentConfiguration")]
        public AgentProperties AgentConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the URL(absolute or relative) of the source context.
        /// It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from
        /// calling listBuildSourceUploadUrl API.
        /// </summary>
        [JsonProperty(PropertyName = "sourceLocation")]
        public string SourceLocation { get; set; }

        /// <summary>
        /// Gets or sets the properties that describes a set of credentials
        /// that will be used when this run is invoked.
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TaskFilePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TaskFilePath");
            }
            if (Platform == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Platform");
            }
            if (Values != null)
            {
                foreach (var element in Values)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Timeout > 28800)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Timeout", 28800);
            }
            if (Timeout < 300)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Timeout", 300);
            }
            if (Platform != null)
            {
                Platform.Validate();
            }
        }
    }
}
