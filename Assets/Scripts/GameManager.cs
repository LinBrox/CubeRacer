using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gamehasEnded = false;
    public float restartDelay = 1f;
    public GameObject compleLevelUI;
    public PlayerMovement playerMovement;

    private void Awake()
    {
        gamehasEnded = false;
    }
    public void CompleteLevel()
    {
        playerMovement.PlayerStopMovement();
        compleLevelUI.SetActive(true);
        gamehasEnded = false;
    }

    public void EndGame ()
    {
        if (gamehasEnded == false)
        {          
            gamehasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        gamehasEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
