using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver){
            SceneManager.LoadScene("Level 01");
        }
    }
}
