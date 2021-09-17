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
using UnityEngine;

namespace zapnet
{
    /// <summary>
    /// Contains state data for controllable entities.
    /// </summary>
    public class ControllableState : EntityState
    {
        /// <summary>
        /// The last input sequence number processed by the server.
        /// </summary>
        [HideInInspector] public int lastSequenceNumber;

        public override void Write(BaseEntity entity, NetOutgoingMessage buffer, bool isSpawning)
        {
            base.Write(entity, buffer, isSpawning);

            buffer.Write(lastSequenceNumber);
        }

        public override void Read(BaseEntity entity, NetIncomingMessage buffer, bool isSpawning)
        {
            base.Read(entity, buffer, isSpawning);

            lastSequenceNumber = buffer.ReadInt32();
        }
    }
}
