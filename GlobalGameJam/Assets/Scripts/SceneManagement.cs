using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public static SceneManagement instance;

    private void Awake() {
        instance = this;
    }
    int colorCount = 0;

   

    public void StartGame()
    {   
        SceneManager.LoadScene(1);    
    }

    public void Update(){
        if(Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


    public void IncreaseColorCount(){
        colorCount += 1;

        if(colorCount == 3){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    
}
