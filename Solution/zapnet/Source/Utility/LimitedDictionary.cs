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

using System.Collections.Generic;

namespace zapnet
{
    /// <summary>
    /// Similar to a regular C# Dictionary except it will only hold a limited amount
    /// of items before it pops one off the head.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class LimitedDictionary<TKey, TValue> : Dictionary<TKey, TValue>
    {
        /// <summary>
        /// The maximum amount of items this dictionary can hold.
        /// </summary>
        public uint MaxItems { get; set; }

        private Queue<TKey> _orderedKeys = new Queue<TKey>();

        public new TValue this[TKey key]
        {
            get
            {
                return base[key];
            }
            set
            {
                if (ContainsKey(key))
                {
                    base[key] = value;
                }
                else
                {
                    Add(key, value);
                }
            }
        }

        public new void Add(TKey key, TValue value)
        {
            _orderedKeys.Enqueue(key);

            if (Count >= MaxItems)
            {
                Remove(_orderedKeys.Dequeue());
            }

            base.Add(key, value);
        }
    }
}
