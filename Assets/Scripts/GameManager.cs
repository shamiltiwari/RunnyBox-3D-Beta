using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    // Function to end the game.

    public float restartDelay = 1f; 
    // Time to delay the restart.
    
    public GameObject CompleteLevelUI;
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", restartDelay); // Invoke is use to call a function with delaying the time.
        }
        
    }

    public void CompleteLevel()
    {
        Debug.Log("Level Won!"); 
        CompleteLevelUI.SetActive(true);
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
