using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Unit : Building
{
    [SerializeField]
    NavMeshAgent agent;
    // Start is called before the first frame update
    private void Awake()
    {
        GetComp();
        GetAgent();
        SetName(name);
    }

    void Start()
    {
        HideLabel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Move(Vector3 point)
    {
        agent.SetDestination(point);
    }

    public virtual void Move(Building building)
    {
        agent.SetDestination(building.transform.position);
    }

    public void GetAgent()
    {
        agent = GetComponent<NavMeshAgent>();
    }
}
