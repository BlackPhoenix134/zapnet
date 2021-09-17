/* 
 * Copyright © dead.gg <https://dead.gg>
 * All Rights Reserved
 * 
 * kurozael <mailto:kurozael@gmail.com>
 * zaekona <mailto:zaekona@gmail.com>
 */

namespace zapnet
{
    /// <summary>
    /// Represents which kind of player a variable should be synchronized with.
    /// </summary>
    public enum SyncTarget
    {
        /// <summary>
        /// Synchronize with all connected players.
        /// </summary>
        All,

        /// <summary>
        /// Synchronize with only the controller of this entity.
        /// </summary>
        Controller
    }
}
