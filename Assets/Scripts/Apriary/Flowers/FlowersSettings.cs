using UnityEngine;

[CreateAssetMenu(fileName = "FlowersSettings", menuName = "MyAssets/FlowerSettings")]
public class FlowersSettings : ScriptableObject
{
    public Transform[] FlowersPrefab;
    
    public IntegerRange StartAmount;
    public float SpawnRate;

    public FloatRange StartHoney;
    public FloatRange HoneyRegeneration;
   
    public float DieHoneyAmount;
    public int MaxBeesOnFlower;
}