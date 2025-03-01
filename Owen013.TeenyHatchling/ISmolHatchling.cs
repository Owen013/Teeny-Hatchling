﻿using System;
using UnityEngine;

namespace SmolHatchling;

public interface ISmolHatchling
{
    /// <summary>
    /// Returns the current scale of the player.
    /// </summary>
    public float GetPlayerScale();

    /// <summary>
    /// Returns the final scale that the player is easing towards.
    /// </summary>
    public float GetPlayerTargetScale();

    /// <summary>
    /// Returns the animation speed multiplier.
    /// </summary>
    public float GetPlayerAnimSpeed();

    /// <summary>
    /// The scale the player will be when they start.
    /// </summary>
    /// <param name="scale">The default scale the player should be.</param>
    public void SetPlayerDefaultScale(float scale);

    /// <summary>
    /// The scale anglerfish will be when they start.
    /// </summary>
    /// <param name="scale">The default scale anglerfish should be.</param>
    public void SetAnglerfishDefaultScale(float scale);

    /// <summary>
    /// The scale anglerfish will be when they start.
    /// </summary>
    /// <param name="scale">The default scale jellyfish should be.</param>
    public void SetJellyfishDefaultScale(float scale);

    /// <summary>
    /// The scale inhabitants will be when they start.
    /// </summary>
    /// <param name="scale">The default scale inhabitants should be.</param>
    public void SetInhabitantDefaultScale(float scale);

    /// <summary>
    /// Resizes a GameObject using its ScaleController. If the GameObject does not have a ScaleController, one will be created.
    /// </summary>
    /// <param name="gameObject">The GameObject to resize.</param>
    /// <param name="scale">The size you want the GameObject to be.</param>
    public void SetGameObjectToScale(GameObject gameObject, float scale);

    /// <summary>
    /// Smoothly resizes a GameObject using its ScaleController. If the GameObject does not have a ScaleController, one will be created.
    /// </summary>
    /// <param name="gameObject">The GameObject to resize.</param>
    /// <param name="scale">The size you want the GameObject to be.</param>
    public void EaseGameObjectScale(GameObject gameObject, float scale);

    [Obsolete("GetTargetScale() is deprecated. Use GetPlayerScale() instead.")]
    public Vector3 GetTargetScale();

    [Obsolete("GetCurrentScale() is deprecated. Use GetPlayerScale() instead.")]
    public Vector3 GetCurrentScale();

    [Obsolete("GetAnimSpeed() is deprecated. Use GetPlayerAnimSpeed() instead.")]
    public float GetAnimSpeed();

    [Obsolete("As of v2.0.0, the player is always using scaled attributes.")]
    public bool UseScaledPlayerAttributes();
}