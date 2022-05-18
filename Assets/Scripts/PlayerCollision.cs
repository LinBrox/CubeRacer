using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager gameManager;

    void OnCollisionEnter(Collision c)
    {
        if (c.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            gameManager.EndGame();
        }

    }
}
