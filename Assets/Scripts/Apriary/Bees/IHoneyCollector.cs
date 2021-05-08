public interface IHoneyCollector
{
    float HoneyCapacity { get; set; }
    float HoneyCollectionSpeed { get; set; }
    void CollectHoney(IHoneySource honeySource);
}