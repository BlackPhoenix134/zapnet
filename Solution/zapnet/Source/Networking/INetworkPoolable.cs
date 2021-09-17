/* 
 * Copyright © dead.gg <https://dead.gg>
 * All Rights Reserved
 * 
 * Unauthorized copying or distribution of this file
 * via any medium is strictly prohibited.
 * 
 * This code is proprietary and confidential.
 * 
 * kurozael <mailto:kurozael@gmail.com>
 * zaekona <mailto:zaekona@gmail.com>
 */

namespace zapnet
{
    /// <summary>
    /// An interface for poolable network objects.
    /// </summary>
    public interface INetworkPoolable
    {
        /// <summary>
        /// When the object has been returned to its pool.
        /// </summary>
        void OnRecycled();

        /// <summary>
        /// When the object has been fetched from its pool.
        /// </summary>
        void OnFetched();
    }
}
