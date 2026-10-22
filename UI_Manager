using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    public Text ScoreOne;
    public Text ScoreTwo;
    public Text Winner;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Set default start message 
        Winner.GetComponent<UnityEngine.UI.Text>().text = "Pong \nThe Game";
    }

    // Update is called once per frame
    void Update()
    {
        ScoreOne.GetComponent<UnityEngine.UI.Text>().text = "Player 1: " + Ball.PlayerOneScore.ToString();
        ScoreTwo.GetComponent<UnityEngine.UI.Text>().text = "Player 2: " + Ball.PlayerTwoScore.ToString();
        PlayerWins();

    }
    void PlayerWins()
    {
        if (Ball.PlayerOneScore >= Ball.MaxScore)
        {
            Winner.GetComponent<UnityEngine.UI.Text>().text = "Player 1\n  Wins!";
        }
        if (Ball.PlayerTwoScore >= Ball.MaxScore) {
        {
            Winner.GetComponent<UnityEngine.UI.Text>().text = "Player 2\n  Wins!"; 
        }
        }
    }
    public void MenuButton() 
    {
        Debug.Log("Menu button pressed");
        SceneManager.LoadScene(0);
    }
    public void OnStartButton() 
    {
        Debug.Log("Start button pressed");
        //Can also go by scene name; SceneManager.LoadScene("GameScene");
        SceneManager.LoadScene(1);
        
        
    }
    public void OnQuitButton()
    {
        Debug.Log("Quit button pressed");
        // Quit the app (only works in build, not in editor)
        Application.Quit();
    }
    //public void 
}
