// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> The properties of the conversion. </summary>
    public partial class AssetConversion
    {
        /// <summary> Initializes a new instance of AssetConversion. </summary>
        /// <param name="conversionId"> The ID of the conversion supplied when the conversion was created. </param>
        /// <param name="options"> Conversion settings describe the origin of input files and destination of output files. </param>
        /// <param name="error"> The error object containing details about the conversion failure. </param>
        /// <param name="status"> The status of the conversion. Terminal states are &apos;Cancelled&apos;, &apos;Failed&apos;, and &apos;Succeeded&apos;. </param>
        /// <param name="createdOn"> The time when the conversion was created. Date and time in ISO 8601 format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversionId"/> or <paramref name="options"/> is null. </exception>
        internal AssetConversion(string conversionId, AssetConversionOptions options, RemoteRenderingServiceError error, AssetConversionStatus status, DateTimeOffset createdOn)
        {
            if (conversionId == null)
            {
                throw new ArgumentNullException(nameof(conversionId));
            }
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            ConversionId = conversionId;
            Options = options;
            Error = error;
            Status = status;
            CreatedOn = createdOn;
        }

        /// <summary> Initializes a new instance of AssetConversion. </summary>
        /// <param name="conversionId"> The ID of the conversion supplied when the conversion was created. </param>
        /// <param name="options"> Conversion settings describe the origin of input files and destination of output files. </param>
        /// <param name="output"> Information about the output of a successful conversion. Only present when the status of the conversion is &apos;Succeeded&apos;. </param>
        /// <param name="error"> The error object containing details about the conversion failure. </param>
        /// <param name="status"> The status of the conversion. Terminal states are &apos;Cancelled&apos;, &apos;Failed&apos;, and &apos;Succeeded&apos;. </param>
        /// <param name="createdOn"> The time when the conversion was created. Date and time in ISO 8601 format. </param>
        internal AssetConversion(string conversionId, AssetConversionOptions options, AssetConversionOutput output, RemoteRenderingServiceError error, AssetConversionStatus status, DateTimeOffset createdOn)
        {
            ConversionId = conversionId;
            Options = options;
            Output = output;
            Error = error;
            Status = status;
            CreatedOn = createdOn;
        }
        /// <summary> Information about the output of a successful conversion. Only present when the status of the conversion is &apos;Succeeded&apos;. </summary>
        public AssetConversionOutput Output { get; }
        /// <summary> The error object containing details about the conversion failure. </summary>
        public RemoteRenderingServiceError Error { get; }
        /// <summary> The status of the conversion. Terminal states are &apos;Cancelled&apos;, &apos;Failed&apos;, and &apos;Succeeded&apos;. </summary>
        public AssetConversionStatus Status { get; }
    }
}
