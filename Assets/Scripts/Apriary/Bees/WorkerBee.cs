public class WorkerBee : IHoneyCollector
{
    public float Honey;
    public float HoneyCapacity { get; set; }
    public float HoneyCollectionSpeed { get; set; }

    public void CollectHoney(IHoneySource honeySource)
    {
        
    }
}