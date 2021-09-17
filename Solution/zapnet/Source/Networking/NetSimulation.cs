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

using System;

namespace zapnet
{
    /// <summary>
    /// Data representing network simulation configuration.
    /// </summary>
    [Serializable]
    public struct NetSimulation
    {
        public float packetLoss;
        public int latency;
    }
}
