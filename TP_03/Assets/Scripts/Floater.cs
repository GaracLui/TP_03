using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script makes objects float up and down while gently spinning.
/// </summary>
public class Floater : MonoBehaviour
{
    #region Public Properties

    /// <summary>
    /// The speed of the object's rotation around the Y-axis (degrees per second).
    /// </summary>
    [Tooltip("Speed of the object's rotation around the Y-axis (degrees per second)")]
    public float SpinSpeed = 5.0f;

    /// <summary>
    /// The amplitude of the object's floating motion (distance it moves up and down).
    /// </summary>
    [Tooltip("Amplitude of the object's floating motion (distance it moves up and down)")]
    public float WaveAmplitude = 0.5f;

    /// <summary>
    /// The frequency of the object's floating motion (cycles per second).
    /// </summary>
    [Tooltip("Frequency of the object's floating motion (cycles per second)")]
    public float WaveFrequency = 0.5f;

    #endregion

    private Vector3 initialPosition; // Stores initial position for efficient calculations

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // Combine rotation and position updates for efficiency
        transform.position = initialPosition + Vector3.up * Mathf.Sin(Time.time * Mathf.PI * WaveFrequency) * WaveAmplitude;
        transform.Rotate(Vector3.up, SpinSpeed * Time.deltaTime);
    }
}

