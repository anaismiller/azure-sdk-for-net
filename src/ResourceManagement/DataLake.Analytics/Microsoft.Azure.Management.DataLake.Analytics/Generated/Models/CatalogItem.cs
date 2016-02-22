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
    /// A Data Lake Analytics catalog item.
    /// </summary>
    public partial class CatalogItem
    {
        /// <summary>
        /// Initializes a new instance of the CatalogItem class.
        /// </summary>
        public CatalogItem() { }

        /// <summary>
        /// Initializes a new instance of the CatalogItem class.
        /// </summary>
        public CatalogItem(string computeAccountName = default(string), string version = default(string))
        {
            ComputeAccountName = computeAccountName;
            Version = version;
        }

        /// <summary>
        /// Gets or sets the name of the Data Lake Analytics account.
        /// </summary>
        [JsonProperty(PropertyName = "computeAccountName")]
        public string ComputeAccountName { get; set; }

        /// <summary>
        /// Gets or sets the version of the catalog item.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}
