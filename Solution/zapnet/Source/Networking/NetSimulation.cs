﻿/* 
 * Copyright © dead.gg <https://dead.gg>
 * All Rights Reserved
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
