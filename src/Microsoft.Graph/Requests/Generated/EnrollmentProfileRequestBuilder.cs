// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type EnrollmentProfileRequestBuilder.
    /// </summary>
    public partial class EnrollmentProfileRequestBuilder : EntityRequestBuilder, IEnrollmentProfileRequestBuilder
    {

        /// <summary>
        /// Constructs a new EnrollmentProfileRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EnrollmentProfileRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IEnrollmentProfileRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IEnrollmentProfileRequest Request(IEnumerable<Option> options)
        {
            return new EnrollmentProfileRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for EnrollmentProfileUpdateDeviceProfileAssignment.
        /// </summary>
        /// <returns>The <see cref="IEnrollmentProfileUpdateDeviceProfileAssignmentRequestBuilder"/>.</returns>
        public IEnrollmentProfileUpdateDeviceProfileAssignmentRequestBuilder UpdateDeviceProfileAssignment(
            IEnumerable<string> deviceIds = null)
        {
            return new EnrollmentProfileUpdateDeviceProfileAssignmentRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.updateDeviceProfileAssignment"),
                this.Client,
                deviceIds);
        }

        /// <summary>
        /// Gets the request builder for EnrollmentProfileSetDefaultProfile.
        /// </summary>
        /// <returns>The <see cref="IEnrollmentProfileSetDefaultProfileRequestBuilder"/>.</returns>
        public IEnrollmentProfileSetDefaultProfileRequestBuilder SetDefaultProfile()
        {
            return new EnrollmentProfileSetDefaultProfileRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.setDefaultProfile"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for EnrollmentProfileExportMobileConfig.
        /// </summary>
        /// <returns>The <see cref="IEnrollmentProfileExportMobileConfigRequestBuilder"/>.</returns>
        public IEnrollmentProfileExportMobileConfigRequestBuilder ExportMobileConfig()
        {
            return new EnrollmentProfileExportMobileConfigRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.exportMobileConfig"),
                this.Client);
        }
    
    }
}