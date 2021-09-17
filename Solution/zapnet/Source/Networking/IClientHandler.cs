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

using Lidgren.Network;

namespace zapnet
{
    /// <summary>
    /// A generic interface for a client handler. Your game must have an implementation of this.
    /// </summary>
    public interface IClientHandler
    {
        /// <summary>
        /// Create and return a credentials packet to send to the server.
        /// </summary>
        /// <returns></returns>
        INetworkPacket GetCredentialsPacket();

        /// <summary>
        /// Process initial data received by the server.
        /// </summary>
        /// <param name="buffer"></param>
        void ReadInitialData(NetIncomingMessage buffer);

        /// <summary>
        /// When the client has disconnected.
        /// </summary>
        void OnDisconnected();

        /// <summary>
        /// When the client has shutdown.
        /// </summary>
        void OnShutdown();
    }
}
