using UnityEngine;
using System.Collections.Generic;

public class Hive
{
    public HiveView HiveView { get; set; }

    public int BeesCount { get; set; }
    public int MaxBeesAmount { get; set; }

    public float Honey { get; set; }
    public float MaxHoneyAmount { get; set; }

    public List<WorkerBee> WorkerBees { get; set; }
    public List<DroneBee> DroneBees { get; set; }

    public void Process()
    {
        ProcessBeesDeath();
        ProcessBeesBirth();
        ProcessBeesBehavior();
    }

    private void ProcessBeesDeath()
    {

    }

    private void ProcessBeesBirth()
    {

    }
    
    private void ProcessBeesBehavior()
    {

    }
    

}