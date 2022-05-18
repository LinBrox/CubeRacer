using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    public float jumpChance;
    public float jumpForce;
    private bool canJump;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (canJump)
        {
            float roll = Random.Range(0f, 100f);
            if (roll < jumpChance)
            {
                rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            }
        }           
    }
    //This stops the obstacles from floating away
    void OnCollisionEnter(Collision c)
    {
        if (c.collider.tag == "Jumpable")
        {
            canJump = true;
        }
    }
    void OnCollisionExit(Collision c)
    {
        if (c.collider.tag == "Jumpable")
        {
            canJump = false;
        }
    }
}
