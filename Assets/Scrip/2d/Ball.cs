using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public float speed;
    public GameObject deathFloor;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>(); // makes rigidbody work
        rigidbody2d.AddForce(new Vector2(0, -speed));
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathFloor")
        {
            //loose life
            transform.position = new Vector2(0, 0);
            //change speed or teleport platform under
        }
    }
    //Loose a life if ball sticks
}
