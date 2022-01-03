using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //when loadNext Scene is called load the game Scene
    public void LoadNextScene()
    {
        SceneManager.LoadScene("Game");
    }
}
