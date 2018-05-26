// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type SynchronizationJobsCollectionRequestBuilder.
    /// </summary>
    public partial class SynchronizationJobsCollectionRequestBuilder : BaseRequestBuilder, ISynchronizationJobsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SynchronizationJobsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SynchronizationJobsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISynchronizationJobsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISynchronizationJobsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SynchronizationJobsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISynchronizationJobRequestBuilder"/> for the specified SynchronizationSynchronizationJob.
        /// </summary>
        /// <param name="id">The ID for the SynchronizationSynchronizationJob.</param>
        /// <returns>The <see cref="ISynchronizationJobRequestBuilder"/>.</returns>
        public ISynchronizationJobRequestBuilder this[string id]
        {
            get
            {
                return new SynchronizationJobRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SynchronizationJobValidateCredentials.
        /// </summary>
        /// <returns>The <see cref="ISynchronizationJobValidateCredentialsRequestBuilder"/>.</returns>
        public ISynchronizationJobValidateCredentialsRequestBuilder ValidateCredentials(
            string applicationIdentifier = null,
            string templateId = null,
            bool? useSavedCredentials = null,
            IEnumerable<SynchronizationSecretKeyStringValuePair> credentials = null)
        {
            return new SynchronizationJobValidateCredentialsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.validateCredentials"),
                this.Client,
                applicationIdentifier,
                templateId,
                useSavedCredentials,
                credentials);
        }
    }
}