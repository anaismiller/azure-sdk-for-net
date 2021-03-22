// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights
{
    /// <summary> A particular API error with an error code and a message. </summary>
    public partial class TimeSeriesOperationError : IReadOnlyDictionary<string, object>
    {
        /// <summary> Initializes a new instance of TimeSeriesOperationError. </summary>
        internal TimeSeriesOperationError()
        {
            Details = new ChangeTrackingList<TimeSeriesOperationErrorDetails>();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of TimeSeriesOperationError. </summary>
        /// <param name="code"> Language-independent, human-readable string that defines a service-specific error code. This code serves as a more specific indicator for the HTTP error code specified in the response. Can be used to programmatically handle specific error cases. </param>
        /// <param name="message"> Human-readable, language-independent representation of the error. It is intended as an aid to developers and is not suitable for exposure to end users. </param>
        /// <param name="target"> Target of the particular error (for example, the name of the property in error). May be null. </param>
        /// <param name="innerError"> Contains more specific error that narrows down the cause. May be null. </param>
        /// <param name="details"> Contains additional error information. May be null. </param>
        /// <param name="additionalProperties"> . </param>
        internal TimeSeriesOperationError(string code, string message, string target, TimeSeriesOperationError innerError, IReadOnlyList<TimeSeriesOperationErrorDetails> details, IReadOnlyDictionary<string, object> additionalProperties)
        {
            Code = code;
            Message = message;
            Target = target;
            InnerError = innerError;
            Details = details;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Language-independent, human-readable string that defines a service-specific error code. This code serves as a more specific indicator for the HTTP error code specified in the response. Can be used to programmatically handle specific error cases. </summary>
        public string Code { get; }
        /// <summary> Human-readable, language-independent representation of the error. It is intended as an aid to developers and is not suitable for exposure to end users. </summary>
        public string Message { get; }
        /// <summary> Target of the particular error (for example, the name of the property in error). May be null. </summary>
        public string Target { get; }
        /// <summary> Contains more specific error that narrows down the cause. May be null. </summary>
        public TimeSeriesOperationError InnerError { get; }
        /// <summary> Contains additional error information. May be null. </summary>
        public IReadOnlyList<TimeSeriesOperationErrorDetails> Details { get; }
        internal IReadOnlyDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public IEnumerable<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public IEnumerable<object> Values => AdditionalProperties.Values;
        /// <inheritdoc cref="IReadOnlyCollection{T}.Count"/>
        int IReadOnlyCollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
        }
    }
}
