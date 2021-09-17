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
    /// An enum representing internally used network channels.
    /// </summary>
    internal enum NetChannel
    {
        /// <summary>
        /// Used to send data specifically for entity states.
        /// </summary>
        EntityStates,

        /// <summary>
        /// Used to send data specifically for player input.
        /// </summary>
        PlayerInput,

        /// <summary>
        /// Used to send data specifically for synchronized variables.
        /// </summary>
        SyncVars
    }
}