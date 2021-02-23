using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public GameObject PanelLevelComplete;

    private bool GameEnded;

    public void GameOver()
    {
        FindObjectOfType<PlayerMove>().enabled = false;
        FindObjectOfType<Score>().enabled = false;
        FindObjectOfType<Text>().text = "Game Over \n (press any key to restart)";
        Invoke("SwitcherGameEnded", 0.5f);
        
    }



    public void LevelCompleted()
    {
        PanelLevelComplete.SetActive(true);
        //Debug.Log("LEVEL COMPLETED!");
    }

    //turn on GameEnded switch for time pouse 
    //between InputKey and GameOver
    private void SwitcherGameEnded()
    {
        GameEnded = true;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("q") && GameEnded == true)
        {
            GameCompleted();
        }
        else if (Input.anyKey && GameEnded == true)
        {
            RestartScene();
        }

    }

    private void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void GameCompleted()
    {
        Debug.Log("Quit");
        Application.Quit();
    }


       


}
