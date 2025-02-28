// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Http message diagnostic settings. </summary>
    public partial class HttpMessageDiagnostic
    {
        /// <summary> Initializes a new instance of HttpMessageDiagnostic. </summary>
        public HttpMessageDiagnostic()
        {
            Headers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of HttpMessageDiagnostic. </summary>
        /// <param name="headers"> Array of HTTP Headers to log. </param>
        /// <param name="body"> Body logging settings. </param>
        /// <param name="dataMasking"> Data masking settings. </param>
        internal HttpMessageDiagnostic(IList<string> headers, BodyDiagnosticSettings body, DataMasking dataMasking)
        {
            Headers = headers;
            Body = body;
            DataMasking = dataMasking;
        }

        /// <summary> Array of HTTP Headers to log. </summary>
        public IList<string> Headers { get; }
        /// <summary> Body logging settings. </summary>
        internal BodyDiagnosticSettings Body { get; set; }
        /// <summary> Number of request body bytes to log. </summary>
        public int? BodyBytes
        {
            get => Body is null ? default : Body.Bytes;
            set
            {
                if (Body is null)
                    Body = new BodyDiagnosticSettings();
                Body.Bytes = value;
            }
        }

        /// <summary> Data masking settings. </summary>
        public DataMasking DataMasking { get; set; }
    }
}
