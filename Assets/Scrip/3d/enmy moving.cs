using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI;
using UnityEngine.AI;

public class enmymoving : MonoBehaviour
{
    public int level;
    public int levelMax;
    public int night;
    int rand;
    public float timer;
    private NavMeshAgent navMeshAgent;
    public Transform targetMove;

    // Start is called before the first frame update
    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        StartCoroutine(Roll(timer - night));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        navMeshAgent.destination = targetMove.position;

        if (rand <= level)
        {
            StartCoroutine(MoveForward());
            rand = 21;
        }
    }

    IEnumerator MoveForward()
    {
        //some code here
        navMeshAgent.destination = targetMove.position;
        navMeshAgent.isStopped = false;
        yield return new WaitForSeconds(3);
        StartCoroutine(Roll(timer - night));
    }

    IEnumerator Roll(float time)
    {
        navMeshAgent.isStopped = true;
        navMeshAgent.ResetPath();
        yield return new WaitForSeconds(time);
        rand = Random.Range(0, levelMax);
    }
}