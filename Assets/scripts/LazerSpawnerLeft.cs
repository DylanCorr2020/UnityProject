using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerSpawnerLeft : MonoBehaviour
{


    /// <summary>
    /// same code as Lazer Horizontal spawner 
    /// </summary>
    public static LazerSpawnerLeft instance;

    public GameObject[] obstaclesL;

    public bool gameOver = false;

    public float waitTime = 0.5f;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {


        StartCoroutine("Spawn");


    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator Spawn()
    {
        //yield return new WaitForSeconds(1f);


        while (!gameOver)
        {


            SpawnObstacleThree();


            yield return new WaitForSeconds(waitTime);

        }



    }


    //if the GameManeger score variable is equal to 6 
    //then  start spwning the left lazers 
    //makes the game more challenging
    void SpawnObstacleThree()
    {
        if(GameManager.instance.score >= 6){


            int random = Random.Range(0, obstaclesL.Length);

            Instantiate(obstaclesL[random], transform.position, Quaternion.identity);



        }



    }

    public void StopSpawning()
    {
        StopCoroutine("Spawn");
    }


}
