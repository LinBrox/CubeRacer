using UnityEngine;

public class EndTrigger : MonoBehaviour { 

    public GameManager gameManager;

    void OnTriggerEnter ()
    {
        if(!gameManager.gamehasEnded)
            gameManager.CompleteLevel();
    }

}
