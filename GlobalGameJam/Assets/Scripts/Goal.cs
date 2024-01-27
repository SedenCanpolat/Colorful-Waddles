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
        gameObject.LeanRotateAround(Vector3.left + Vector3.forward + Vector3.right, 20f, 0.3f).setLoopPingPong();
        //dialogueBubble.SetActive(false);
    }

    public void OpenDialogue()
    {

        Debug.Log("OpenDialogue");
        SpriteRenderer.sprite = Bubble;
        FlagMission = 1;
    }


}
