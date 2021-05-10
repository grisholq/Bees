using UnityEngine;

public class FlowersPositioner : MonoBehaviour
{
    [SerializeField] private FloatRange axisX;
    [SerializeField] private FloatRange axisY;
    [SerializeField] private FloatRange axisZ;

    public void PositionFlower(FlowerView flowerView)
    {
        Vector3 position = new Vector3();

        position.x = axisX.Value;
        position.y = axisY.Value;
        position.z = axisZ.Value;

        flowerView.transform.position = position;
    }
}