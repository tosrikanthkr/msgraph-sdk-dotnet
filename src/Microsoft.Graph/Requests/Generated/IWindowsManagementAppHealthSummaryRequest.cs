// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWindowsManagementAppHealthSummaryRequest.
    /// </summary>
    public partial interface IWindowsManagementAppHealthSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsManagementAppHealthSummary using PUT.
        /// </summary>
        /// <param name="windowsManagementAppHealthSummaryToCreate">The WindowsManagementAppHealthSummary to create.</param>
        /// <returns>The created WindowsManagementAppHealthSummary.</returns>
        System.Threading.Tasks.Task<WindowsManagementAppHealthSummary> CreateAsync(WindowsManagementAppHealthSummary windowsManagementAppHealthSummaryToCreate);        /// <summary>
        /// Creates the specified WindowsManagementAppHealthSummary using PUT.
        /// </summary>
        /// <param name="windowsManagementAppHealthSummaryToCreate">The WindowsManagementAppHealthSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsManagementAppHealthSummary.</returns>
        System.Threading.Tasks.Task<WindowsManagementAppHealthSummary> CreateAsync(WindowsManagementAppHealthSummary windowsManagementAppHealthSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsManagementAppHealthSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsManagementAppHealthSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsManagementAppHealthSummary.
        /// </summary>
        /// <returns>The WindowsManagementAppHealthSummary.</returns>
        System.Threading.Tasks.Task<WindowsManagementAppHealthSummary> GetAsync();

        /// <summary>
        /// Gets the specified WindowsManagementAppHealthSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsManagementAppHealthSummary.</returns>
        System.Threading.Tasks.Task<WindowsManagementAppHealthSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsManagementAppHealthSummary using PATCH.
        /// </summary>
        /// <param name="windowsManagementAppHealthSummaryToUpdate">The WindowsManagementAppHealthSummary to update.</param>
        /// <returns>The updated WindowsManagementAppHealthSummary.</returns>
        System.Threading.Tasks.Task<WindowsManagementAppHealthSummary> UpdateAsync(WindowsManagementAppHealthSummary windowsManagementAppHealthSummaryToUpdate);

        /// <summary>
        /// Updates the specified WindowsManagementAppHealthSummary using PATCH.
        /// </summary>
        /// <param name="windowsManagementAppHealthSummaryToUpdate">The WindowsManagementAppHealthSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WindowsManagementAppHealthSummary.</returns>
        System.Threading.Tasks.Task<WindowsManagementAppHealthSummary> UpdateAsync(WindowsManagementAppHealthSummary windowsManagementAppHealthSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagementAppHealthSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagementAppHealthSummaryRequest Expand(Expression<Func<WindowsManagementAppHealthSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagementAppHealthSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagementAppHealthSummaryRequest Select(Expression<Func<WindowsManagementAppHealthSummary, object>> selectExpression);

    }
}