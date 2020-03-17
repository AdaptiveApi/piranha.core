/*
 * Copyright (c) 2020 Piranha CMS
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/piranhacms/piranha
 *
 */

using System;
using System.Threading.Tasks;
using Piranha.Models;

namespace Piranha.Repositories
{
    public interface IContentRepository
    {
        /// <summary>
        /// Gets the content model with the specified id.
        /// </summary>
        /// <typeparam name="T">The model type</typeparam>
        /// <param name="id">The unique id</param>
        /// <param name="languageId">The selected language id</param>
        /// <returns>The content model</returns>
        Task<T> GetByIdAsync<T>(Guid id, Guid languageId) where T : Content;

        /// <summary>
        /// Saves the given content model
        /// </summary>
        /// <param name="model">The content model</param>
        /// <param name="languageId">The selected language id</param>
        Task SaveAsync<T>(T model, Guid languageId) where T : Content;

        /// <summary>
        /// Deletes the content model with the specified id.
        /// </summary>
        /// <param name="id">The unique id</param>
        Task DeleteAsync(Guid id);
    }
}
