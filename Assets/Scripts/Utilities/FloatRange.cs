using System;
using UnityEngine;

[Serializable]
public class FloatRange
{
    [SerializeField] private float min;
    [SerializeField] private float max;

    public float Min { get => min; }
    public float Max { get => max; }

    public float Value
    {
        get => UnityEngine.Random.Range(min, max);                        
    }
}