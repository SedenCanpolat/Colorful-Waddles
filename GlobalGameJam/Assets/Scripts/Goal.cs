using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Sprite Bubble;
    public Sprite StartBubble;
    public SpriteRenderer SpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
         SpriteRenderer.sprite = StartBubble;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CloseDialogue(){
       // SetActive(false);
    }

    public void OpenDialogue(){

        Debug.Log("OpenDialogue");
        SpriteRenderer.sprite = Bubble;
    }
}
