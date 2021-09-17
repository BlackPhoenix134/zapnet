/* 
 * Copyright © dead.gg <https://dead.gg>
 * All Rights Reserved
 * 
 * kurozael <mailto:kurozael@gmail.com>
 * zaekona <mailto:zaekona@gmail.com>
 */

using UnityEngine;

namespace zapnet
{
    /// <summary>
    /// Data representing buffered interpolation data for entities.
    /// </summary>
    public struct BufferTransform
    {
        /// <summary>
        /// The universal timestamp when this data was received from the server.
        /// </summary>
        public ulong timestamp;

        /// <summary>
        /// The position data received from the server at this time.
        /// </summary>
        public Vector3 position;

        /// <summary>
        /// The rotation data received from the server at this time.
        /// </summary>
        public Quaternion rotation;
    }
}
