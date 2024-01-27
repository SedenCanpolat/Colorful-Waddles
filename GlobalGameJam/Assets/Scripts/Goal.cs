using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Sprite Bubble;
    public Sprite StartBubble;
    public SpriteRenderer SpriteRenderer;
    public int FlagMission = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer.sprite = StartBubble;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CloseDialogue()
    {
        SpriteRenderer.sprite = null;
    }

    public void OpenDialogue()
    {

        Debug.Log("OpenDialogue");
        SpriteRenderer.sprite = Bubble;
        FlagMission = 1;
    }


}
