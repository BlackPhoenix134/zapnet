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
    /// A base event input data class that should be inherited to send input data to the server.
    /// </summary>
    public class BaseInputEvent : BaseEventData
    {
        /// <summary>
        /// The unique sequence number for this input event.
        /// </summary>
        public int SequenceNumber { get; set; }

        public override void Write(NetOutgoingMessage buffer)
        {
            buffer.Write(SequenceNumber);
        }

        public override bool Read(NetIncomingMessage buffer)
        {
            SequenceNumber = buffer.ReadInt32();

            return true;
        }

        public override void Recycle() { }
    }
}
