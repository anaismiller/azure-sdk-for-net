// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Data Lake Analytics catalog U-SQL assembly file information item.
    /// </summary>
    public partial class USqlAssemblyFileInfo
    {
        /// <summary>
        /// Initializes a new instance of the USqlAssemblyFileInfo class.
        /// </summary>
        public USqlAssemblyFileInfo() { }

        /// <summary>
        /// Initializes a new instance of the USqlAssemblyFileInfo class.
        /// </summary>
        public USqlAssemblyFileInfo(FileType? type = default(FileType?), string originalPath = default(string), string contentPath = default(string))
        {
            Type = type;
            OriginalPath = originalPath;
            ContentPath = contentPath;
        }

        /// <summary>
        /// Gets or sets the assembly file type. Possible values for this
        /// property include: 'Assembly', 'Resource'.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FileType? Type { get; set; }

        /// <summary>
        /// Gets or sets the the original path to the assembly file.
        /// </summary>
        [JsonProperty(PropertyName = "originalPath")]
        public string OriginalPath { get; set; }

        /// <summary>
        /// Gets or sets the the content path to the assembly file.
        /// </summary>
        [JsonProperty(PropertyName = "contentPath")]
        public string ContentPath { get; set; }

    }
}
