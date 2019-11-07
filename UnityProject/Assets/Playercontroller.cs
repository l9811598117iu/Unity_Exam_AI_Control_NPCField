using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [Range(10, 100)]
    public float speed = 10;
    [Range(10, 100)]
    public int jump = 10;
    Rigidbody r3d;
    public bool isGround;

    // Use this for initialization
    void Start()
    {
        r3d = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        Jump();
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGround = true;
        Debug.Log("touch" + collision.gameObject);
    }

    private void Walk()
    {
        r3d.AddForce(new Vector3(speed * Input.GetAxis("Horizontal"), 0,0));
        r3d.AddForce(new Vector3( 0, 0, speed * Input.GetAxis("Vertical")));

    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = false;
            r3d.AddForce(new Vector3(0, jump,0));
        }

    }
}
