using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Sprite Bubble;
    public Sprite StartBubble;
    public SpriteRenderer SpriteRenderer;

    public Item PersonalizedItem;

    // Start is called before the first frame update
    void Start()
    {
         SpriteRenderer.sprite = StartBubble;
    }


    private void CloseDialogue(){
       // SetActive(false);
    }

    public void OpenDialogue(){

        Debug.Log("OpenDialogue");
        SpriteRenderer.sprite = Bubble;
    }
}
