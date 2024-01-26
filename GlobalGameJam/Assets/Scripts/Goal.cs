using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public string Dia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CloseDialogue(){
       // SetActive(false);
    }

    public void OpenDialogue(){
        Debug.Log(Dia);
    }
}
