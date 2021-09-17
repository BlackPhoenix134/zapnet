/* 
 * Copyright © dead.gg <https://dead.gg>
 * All Rights Reserved
 * 
 * kurozael <mailto:kurozael@gmail.com>
 * zaekona <mailto:zaekona@gmail.com>
 */

namespace zapnet
{
    public delegate void OnProcessEvent<T>(T evnt) where T : INetworkPacket;

    /// <summary>
    /// Data representing an event listener. Used for all subscriptions to network events.
    /// </summary>
    public struct EventListener
    {
        /// <summary>
        /// The callback that should be invoked when the event fires.
        /// </summary>
        public OnProcessEvent<INetworkPacket> callback;

        /// <summary>
        /// The original callback used for comparison purposes when
        /// removing existing event listeners.
        /// </summary>
        public object original;
    }
}
