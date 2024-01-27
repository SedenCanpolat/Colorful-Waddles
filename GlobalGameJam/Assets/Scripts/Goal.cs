using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Sprite Bubble;
    public Sprite StartBubble;
    public SpriteRenderer SpriteRenderer;

    public Item PersonalizedItem;
    //public GameObject dialogueBubble;
    public int FlagMission = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer.sprite = StartBubble;
    }


    public void CloseDialogue()
    {
        SpriteRenderer.sprite = null;
        //dialogueBubble.SetActive(false);
    }

    public void OpenDialogue()
    {

        Debug.Log("OpenDialogue");
        SpriteRenderer.sprite = Bubble;
        FlagMission = 1;
    }


}
