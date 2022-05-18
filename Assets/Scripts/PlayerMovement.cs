using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 100f;
    [HideInInspector]
    public bool canJump = true;


    private bool _isJumping = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            _isJumping = true;
        }
    }
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {   
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }   
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
        if (_isJumping)
        {
            Debug.Log("Jump");
            rb.AddForce(0, jumpForce, 0 , ForceMode.Impulse);
            _isJumping = false;
        }
        //Debug.Log(rb.velocity);
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
    