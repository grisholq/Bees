public class Flower : IHoneySource
{
    public FlowerView FlowerView { get; set; }
    public float Honey { get; set; }
    public float HoneyRegeneration { get; set; }
    public int MaxBees { get; set; }
}