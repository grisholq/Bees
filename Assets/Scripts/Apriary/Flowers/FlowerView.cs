using UnityEngine;

public class FlowerView : MonoBehaviour
{
    public Flower FlowerModel { get; set; }

    public void Die()
    {
        Destroy(gameObject);
    }
}