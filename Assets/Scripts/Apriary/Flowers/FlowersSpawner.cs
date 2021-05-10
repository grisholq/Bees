using UnityEngine;
using System.Collections.Generic;

public class FlowersSpawner : MonoBehaviour
{
    [SerializeField] private FlowersFactory factory;
    [SerializeField] private FloatRange AxisX;
    [SerializeField] private FloatRange AxisY;
    [SerializeField] private FloatRange AxisZ;

    public List<Flower> SpawnFlowers(int amount)
    {
        List<Flower> flowers = new List<Flower>(amount);

        for (int i = 0; i < amount; i++)
        {
            flowers.Add(SpawnFlower());
        }
    
        return flowers;
    }

    public Flower SpawnFlower()
    {   
        Flower flower = factory.GetFlower();
        flower.FlowerView.transform.position = GetRandomPosition();
        return flower;
    }

    private Vector3 GetRandomPosition()
    {
        Vector3 position = new Vector3();

        position.x = AxisX.Value;
        position.y = AxisY.Value;
        position.z = AxisZ.Value;

        return position;
    }
}