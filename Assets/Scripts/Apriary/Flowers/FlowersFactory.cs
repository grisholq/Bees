using UnityEngine;

public class FlowersFactory : MonoBehaviour
{
    [SerializeField] private FlowersSettings settings;
    [SerializeField] private Transform parent;

    public Flower GetFlower()
    {
        
        Flower flower = new Flower();
        FlowerView view = GetFlowerPrefab().AddComponent<FlowerView>();

        view.FlowerModel = flower;

        flower.FlowerView = view;
        flower.Honey = settings.StartHoney.Value;
        flower.HoneyRegeneration = settings.HoneyRegeneration.Value;
        flower.MaxBees = settings.MaxBeesOnFlower;

        return flower;
    }

    private GameObject GetFlowerPrefab()
    {
        int index = Random.Range(0, settings.FlowersPrefab.Length);
        return Instantiate(settings.FlowersPrefab[index], parent).gameObject;
    }
}