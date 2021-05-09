using System;
using UnityEngine;

[Serializable]
public class IntegerRange
{
    [SerializeField] private int min;
    [SerializeField] private int max;

    public int Min { get => min; }
    public int Max { get => max; }

    public int Value
    {
        get => UnityEngine.Random.Range(min, max);
    }
}