/*
 * Copyright (C) Sportradar AG. See LICENSE for full license governing this code
 */

using System.Collections;

namespace Sportradar.MTS.SDK.Entities.Utils
{
    /// <summary>
    /// Extension methods for collections
    /// </summary>
    static class CollectionExtensions
    {
        /// <summary>
        /// Checks whether or not collection is null or empty. Assumes colleciton can be safely enumerated multiple times.
        /// </summary>
        /// <param name = "this"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this IEnumerable @this)
        {
            return @this == null || @this.GetEnumerator().MoveNext() == false;
        }
    }
}