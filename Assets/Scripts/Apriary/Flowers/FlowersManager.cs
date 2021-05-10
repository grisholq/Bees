using UnityEngine;
using System.Collections.Generic;

public class FlowersManager : MonoBehaviour
{
    [SerializeField] private FlowersFactory factory;
    [SerializeField] private FlowersSettings settings;

    private float flowersToSpawn;

    public int FlowersToSpawn { get => (int)flowersToSpawn; }

    private void Awake()
    {
        flowersToSpawn = 0;
    }

    private void Update()
    {
        flowersToSpawn += Time.deltaTime * settings.SpawnRate;
    }
}