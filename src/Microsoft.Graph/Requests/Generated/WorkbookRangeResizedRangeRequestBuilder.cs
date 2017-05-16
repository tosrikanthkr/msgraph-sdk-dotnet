// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookRangeResizedRangeRequestBuilder.
    /// </summary>
    public partial class WorkbookRangeResizedRangeRequestBuilder : BaseFunctionMethodRequestBuilder<IWorkbookRangeResizedRangeRequest>, IWorkbookRangeResizedRangeRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookRangeResizedRangeRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="deltaRows">A deltaRows parameter for the OData method call.</param>
        /// <param name="deltaColumns">A deltaColumns parameter for the OData method call.</param>
        public WorkbookRangeResizedRangeRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Int32 deltaRows,
            Int32 deltaColumns)
            : base(requestUrl, client)
        {
            this.SetParameter("deltaRows", deltaRows, false);
            this.SetParameter("deltaColumns", deltaColumns, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookRangeResizedRangeRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookRangeResizedRangeRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}