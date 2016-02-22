// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes Storage Resource Usage.
    /// </summary>
    public partial class Usage
    {
        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        public Usage() { }

        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        public Usage(UsageUnit? unit, int? currentValue, int? limit, UsageName name)
        {
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
        }

        /// <summary>
        /// Gets the unit of measurement. Possible values for this property
        /// include: 'Count', 'Bytes', 'Seconds', 'Percent',
        /// 'CountsPerSecond', 'BytesPerSecond'.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public UsageUnit? Unit { get; set; }

        /// <summary>
        /// Gets the current count of the allocated resources in the
        /// subscription.
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public int? CurrentValue { get; set; }

        /// <summary>
        /// Gets the maximum count of the resources that can be allocated in
        /// the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Gets the name of the type of usage.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public UsageName Name { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Unit == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Unit");
            }
            if (CurrentValue == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CurrentValue");
            }
            if (Limit == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Limit");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
