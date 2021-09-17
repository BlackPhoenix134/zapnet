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

using UnityEngine;

namespace zapnet
{
    /// <summary>
    /// Contains internally used network settings. You can change these in your game but be careful.
    /// </summary>
    public static class NetSettings
    {
        public const uint StatePriority = 8;
        public const string AuthId = "Zapnet";
        public const string AppId = "Zapnet";
        public const uint TickRate = 50;
    }
}
