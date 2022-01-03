using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //create game Manager instance so it can be used in other scripts
    public static GameManager instance;

    public GameObject gameOverMenu;

    //text to show score 
    public Text scoreText;

    //to show score after the game 
    public Text displayScore;

    //score int 
    public int score = 0;

    bool gameOver = false;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
       
    }

    //method to display score 
    //convert to a string 
    public void DisplayScore()
    {
        displayScore.text = "Score: " + score.ToString();
    }


    //method called when its gameover and stop spawning all lazer spawners
    public void GameOver()
    {
        LazerSpawner.instance.StopSpawning();
        lazerVSpawner.instance.StopSpawning();
        LazerSpawnerLeft.instance.StopSpawning();

        //set the gameover menu to true 
        //gameObject shows on screen
        gameOverMenu.SetActive(true);
        DisplayScore();

    }

    //when its not gameOver 
    //increment score at the bottom of screen
    public void IncrementScore()
    {
        if(!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
            print(score);

        }
        

    }


    //when this method is called reload the game scene 
    public void restart()
    {
        SceneManager.LoadScene("Game");
    }


    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
