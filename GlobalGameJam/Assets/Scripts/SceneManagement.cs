using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public static SceneManagement instance;
    public CanvasGroup VinImage;

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
        VinImage.LeanAlpha(0.33f * (3-colorCount), 1f);
        if(colorCount == 3){
           Invoke("LoadEnding", 2.4f);
        }
    }

    void LoadEnding(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
