/* 
 * Copyright � dead.gg <https://dead.gg>
 * All Rights Reserved
 * 
 * kurozael <mailto:kurozael@gmail.com>
 * zaekona <mailto:zaekona@gmail.com>
 */

using Lidgren.Network;

namespace zapnet
{
    /// <summary>
    /// An event fired when a player gains control of an entity.
    /// </summary>
    public class ControlGainedEvent : BaseEventData
    {
        /// <summary>
        /// The controllable entity.
        /// </summary>
        public BaseEntity Controllable { get; set; }

        /// <summary>
        /// The controlling player.
        /// </summary>
        public Player Controller { get; set; }

        public override void Write(NetOutgoingMessage buffer)
        {
            buffer.Write(Controllable.EntityId);
            buffer.Write(Controller.PlayerId);
        }

        public override bool Read(NetIncomingMessage buffer)
        {
            Controllable = Zapnet.Entity.Find(buffer.ReadUInt32());
            Controller = Zapnet.Player.Find(buffer.ReadUInt32());

            return true;
        }
    }
}
