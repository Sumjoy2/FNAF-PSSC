using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class enmymoving : MonoBehaviour
{
    //allows the seting of level stuff in engine
    [Header("LevelStuff")]
    public int level;
    public int levelMax;
    public int night;
    int rand;
    public float timer;

    //setting the transforms of things
    [Header("Transforms")]
    public Transform bounceBack;
    private NavMeshAgent navMeshAgent;
    public GameObject[] targetMove;
    private int moveCurrent;

    // Start is called before the first frame update
    void Awake()
    {
        //gets nav mesh and starts the first roll
        navMeshAgent = GetComponent<NavMeshAgent>();
        StartCoroutine(Roll(timer - night));
        moveCurrent = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        navMeshAgent.destination = targetMove[moveCurrent].transform.position;
        //moves if rand is less than or equal to level
        if (rand <= level)
        {
            StartCoroutine(MoveForward());
            rand = 21;
        }
        if (Vector3.Distance(transform.position ,targetMove[moveCurrent].transform.position) < 1.0) 
        {
            moveCurrent++;
        }
    }

    //checks if hits door then throws back to bounce back position
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            transform.position = bounceBack.position;
            moveCurrent = 0;
        }
    }

    /*/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/
     * magic bits that make things work
     /-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/*/

    //sets destination back to target move, moves forward for 3 seconds then rolls a new number
    IEnumerator MoveForward()
    {
        navMeshAgent.destination = targetMove[moveCurrent].transform.position;
        navMeshAgent.isStopped = false;
        yield return new WaitForSeconds(3);
        StartCoroutine(Roll(timer - night));
    }
    //stops movement, and after time rolls a new number
    IEnumerator Roll(float time)
    {
        navMeshAgent.isStopped = true;
        navMeshAgent.destination = transform.position;
        yield return new WaitForSeconds(time);
        rand = Random.Range(0, levelMax);
    }
}