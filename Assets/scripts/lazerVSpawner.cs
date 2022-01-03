using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazerVSpawner : MonoBehaviour
{
    //create instance of the lazer spawner vertical 
    public static lazerVSpawner instance;

    public GameObject lazerV;

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


                SpawnObstacleTwo();


                yield return new WaitForSeconds(waitTime);

            }
       

       
    }

    void SpawnObstacleTwo()
    {
        if (GameManager.instance.score >= 3)
        {
            Instantiate(lazerV, transform.position, Quaternion.identity);
        }
     }

    public void StopSpawning()
    {
        StopCoroutine("Spawn");
    }

   
}
