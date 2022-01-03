using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerSpawner : MonoBehaviour
{

    //create instance variale of lazer spawner so that it can be used in the other scriptrs
    public static LazerSpawner instance;



    //public GameObject obstacle;

    //create an array of gameobjects of horizontal lazers
    public GameObject[] obstaclesH;

    //boolean variable for agme over 
    public bool gameOver = false;

    //spawning wait time 
    public float waitTime = 0.5f;


    //starts before unity game starts
    private void Awake()
    {
        instance = this;
    }



    // Start is called before the first frame update
    void Start()
    {   
        //start the coroutine of spawning the lazers
        StartCoroutine("Spawn");
    }


    //
    IEnumerator Spawn()
    {
        //yield return new WaitForSeconds(1f);

        //while its not game over 
        //call method spawn obstacle and wait a few seconds spawn again
        

        while (!gameOver)
        {

            SpawnObstacle();

            yield return new WaitForSeconds(waitTime);
        }
       
    }


    //create a variable that creates a random number between length of horizontal lazers array.
    //Instantiate the random index of gameObject array from the spawners transform.position
    void SpawnObstacle()
    {

        int random = Random.Range(0, obstaclesH.Length);

        Instantiate(obstaclesH[random], transform.position, Quaternion.identity);
    }


    //method that will stop the lazers spawning 
    public  void StopSpawning()
    {
        StopCoroutine("Spawn");
    }




}
