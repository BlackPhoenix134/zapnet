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
    /// An enum representing the type of a network event.
    /// </summary>
    public enum NetworkEventType
    {
        /// <summary>
        /// These events are sent and received in global space.
        /// </summary>
        Global,

        /// <summary>
        /// These events are only sent to a specific entity.
        /// </summary>
        Entity
    }
}
