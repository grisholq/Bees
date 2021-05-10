using System.Collections.Generic;
using UnityEngine;

public class FlowersManager : MonoBehaviour
{
    [SerializeField] private FlowersSpawner spawner;
    [SerializeField] private int amount;

    private void Start()
    {
        spawner.SpawnFlowers(amount);
    }
}