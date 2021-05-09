using UnityEngine;
using UnityEngine.AI;

public class BeeView : MonoBehaviour
{
    private NavMeshAgent meshAgent;

    private void Awake()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        
    }

    private void SetDestination(Transform destination)
    {

    }



}