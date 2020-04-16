// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace azure_special_properties
{
    public partial class SubscriptionInMethodClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal SubscriptionInMethodRestClient RestClient { get; }
        /// <summary> Initializes a new instance of SubscriptionInMethodClient for mocking. </summary>
        protected SubscriptionInMethodClient()
        {
        }
        /// <summary> Initializes a new instance of SubscriptionInMethodClient. </summary>
        internal SubscriptionInMethodClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new SubscriptionInMethodRestClient(clientDiagnostics, pipeline, host);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="subscriptionId"> This should appear as a method parameter, use value &apos;1234-5678-9012-3456&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostMethodLocalValidAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostMethodLocalValidAsync(subscriptionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="subscriptionId"> This should appear as a method parameter, use value &apos;1234-5678-9012-3456&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostMethodLocalValid(string subscriptionId, CancellationToken cancellationToken = default)
        {
            return RestClient.PostMethodLocalValid(subscriptionId, cancellationToken);
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = null, client-side validation should prevent you from making this call. </summary>
        /// <param name="subscriptionId"> This should appear as a method parameter, use value null, client-side validation should prvenet the call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostMethodLocalNullAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostMethodLocalNullAsync(subscriptionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = null, client-side validation should prevent you from making this call. </summary>
        /// <param name="subscriptionId"> This should appear as a method parameter, use value null, client-side validation should prvenet the call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostMethodLocalNull(string subscriptionId, CancellationToken cancellationToken = default)
        {
            return RestClient.PostMethodLocalNull(subscriptionId, cancellationToken);
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="subscriptionId"> Should appear as a method parameter -use value &apos;1234-5678-9012-3456&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostPathLocalValidAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostPathLocalValidAsync(subscriptionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="subscriptionId"> Should appear as a method parameter -use value &apos;1234-5678-9012-3456&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostPathLocalValid(string subscriptionId, CancellationToken cancellationToken = default)
        {
            return RestClient.PostPathLocalValid(subscriptionId, cancellationToken);
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="subscriptionId"> The subscriptionId, which appears in the path, the value is always &apos;1234-5678-9012-3456&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostSwaggerLocalValidAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostSwaggerLocalValidAsync(subscriptionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="subscriptionId"> The subscriptionId, which appears in the path, the value is always &apos;1234-5678-9012-3456&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostSwaggerLocalValid(string subscriptionId, CancellationToken cancellationToken = default)
        {
            return RestClient.PostSwaggerLocalValid(subscriptionId, cancellationToken);
        }
    }
}