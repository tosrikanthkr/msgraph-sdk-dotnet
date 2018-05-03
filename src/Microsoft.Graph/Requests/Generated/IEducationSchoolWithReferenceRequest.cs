// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IEducationSchoolWithReferenceRequest.
    /// </summary>
    public partial interface IEducationSchoolWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified EducationSchool.
        /// </summary>
        /// <returns>The EducationSchool.</returns>
        System.Threading.Tasks.Task<EducationSchool> GetAsync();

        /// <summary>
        /// Gets the specified EducationSchool.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationSchool.</returns>
        System.Threading.Tasks.Task<EducationSchool> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified EducationSchool using PUT.
        /// </summary>
        /// <param name="educationSchoolToCreate">The EducationSchool to create.</param>
        /// <returns>The created EducationSchool.</returns>
        System.Threading.Tasks.Task<EducationSchool> CreateAsync(EducationSchool educationSchoolToCreate);        /// <summary>
        /// Creates the specified EducationSchool using PUT.
        /// </summary>
        /// <param name="educationSchoolToCreate">The EducationSchool to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationSchool.</returns>
        System.Threading.Tasks.Task<EducationSchool> CreateAsync(EducationSchool educationSchoolToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified EducationSchool using PATCH.
        /// </summary>
        /// <param name="educationSchoolToUpdate">The EducationSchool to update.</param>
        /// <returns>The updated EducationSchool.</returns>
        System.Threading.Tasks.Task<EducationSchool> UpdateAsync(EducationSchool educationSchoolToUpdate);

        /// <summary>
        /// Updates the specified EducationSchool using PATCH.
        /// </summary>
        /// <param name="educationSchoolToUpdate">The EducationSchool to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EducationSchool.</returns>
        System.Threading.Tasks.Task<EducationSchool> UpdateAsync(EducationSchool educationSchoolToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified EducationSchool.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EducationSchool.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSchoolWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSchoolWithReferenceRequest Expand(Expression<Func<EducationSchool, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSchoolWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSchoolWithReferenceRequest Select(Expression<Func<EducationSchool, object>> selectExpression);

    }
}