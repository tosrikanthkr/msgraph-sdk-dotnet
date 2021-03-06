// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IMessageRequest.
    /// </summary>
    public partial interface IMessageRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Message using POST.
        /// </summary>
        /// <param name="messageToCreate">The Message to create.</param>
        /// <returns>The created Message.</returns>
        System.Threading.Tasks.Task<Message> CreateAsync(Message messageToCreate);        /// <summary>
        /// Creates the specified Message using POST.
        /// </summary>
        /// <param name="messageToCreate">The Message to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Message.</returns>
        System.Threading.Tasks.Task<Message> CreateAsync(Message messageToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Message.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Message.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Message.
        /// </summary>
        /// <returns>The Message.</returns>
        System.Threading.Tasks.Task<Message> GetAsync();

        /// <summary>
        /// Gets the specified Message.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Message.</returns>
        System.Threading.Tasks.Task<Message> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Message using PATCH.
        /// </summary>
        /// <param name="messageToUpdate">The Message to update.</param>
        /// <returns>The updated Message.</returns>
        System.Threading.Tasks.Task<Message> UpdateAsync(Message messageToUpdate);

        /// <summary>
        /// Updates the specified Message using PATCH.
        /// </summary>
        /// <param name="messageToUpdate">The Message to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Message.</returns>
        System.Threading.Tasks.Task<Message> UpdateAsync(Message messageToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMessageRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMessageRequest Expand(Expression<Func<Message, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMessageRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMessageRequest Select(Expression<Func<Message, object>> selectExpression);

    }
}
