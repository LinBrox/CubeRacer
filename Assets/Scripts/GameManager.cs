using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gamehasEnded = false;
    public float restartDelay = 1f;
    public GameObject compleLevelUI;

    public void CompleteLevel()
    {
        compleLevelUI.SetActive(true);
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
