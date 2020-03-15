/*
 * Copyright (c) 2020 Piranha CMS
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/piranhacms/piranha
 *
 */

using System.Threading.Tasks;
using Piranha.Models;

namespace Piranha.Services
{
    /// <summary>
    /// The content factory is responsible for creating models and
    /// initializing them after they have been loaded.
    /// </summary>
    public interface IContentFactory
    {
        /// <summary>
        /// Creates and initializes a new content model.
        /// </summary>
        /// <param name="type">The content type</param>
        /// <typeparam name="T">The model type</typeparam>
        /// <returns>The new model</returns>
        Task<T> CreateAsync<T>(ContentType type) where T : Content;

        /// <summary>
        /// Initializes the given model.
        /// </summary>
        /// <param name="model">The model</param>
        /// <param name="type">The content type</param>
        /// <typeparam name="T">The model type</typeparam>
        /// <returns>The initialized model</returns>
        Task<T> InitAsync<T>(T model, ContentType type) where T : Content;
    }
}