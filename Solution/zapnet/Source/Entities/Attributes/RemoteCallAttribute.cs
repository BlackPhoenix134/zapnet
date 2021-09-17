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
    /// Indicates that a method can be called remotely.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
    public class RemoteCallAttribute : Attribute
    {
        /// <summary>
        /// Whether or not to invoke the method locally before calling remotely.
        /// </summary>
        public bool InvokeOnSelf { get; set; }
    }
}
