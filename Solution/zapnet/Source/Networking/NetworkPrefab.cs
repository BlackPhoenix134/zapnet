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
using System;

/// <summary>
/// A behaviour to indicate this prefab can be instantiated across the network.
/// </summary>
[ExecuteInEditMode]
public class NetworkPrefab : MonoBehaviour
{
    /// <summary>
    /// Generate a new unique identifier for this prefab.
    /// </summary>
    /// <returns></returns>
    public static string GenerateIdentifier()
    {
        return Guid.NewGuid().ToString().Replace("-", "");
    }

    /// <summary>
    /// The unique name attributed to this network prefab.
    /// </summary>
    [Header("Base Settings")]
    public string uniqueName = GenerateIdentifier();

    /// <summary>
    /// Used in the Unity Inspector to regenerate the unique identifier.
    /// </summary>
    [SerializeField]
    internal bool regenerate;

    private void OnValidate()
    {
        if (regenerate)
        {
            uniqueName = GenerateIdentifier();
            regenerate = false;
        }
    }
}
