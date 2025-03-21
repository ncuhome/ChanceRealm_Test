// MoveTo.cs
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{

    private Transform goal;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        goal= GetComponent<Transform>();
    }
    private void Update()
    {
        goal.position = agent.transform.position;
    }
}
