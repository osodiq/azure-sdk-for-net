// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.AI.FormRecognizer
{
    internal class FormRecognizerAnalyzeInvoiceAsyncHeaders
    {
        private readonly Response _response;
        public FormRecognizerAnalyzeInvoiceAsyncHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> URL containing the resultId used to track the progress and obtain the result of the analyze operation. </summary>
        public string OperationLocation => _response.Headers.TryGetValue("Operation-Location", out string value) ? value : null;
    }
}
