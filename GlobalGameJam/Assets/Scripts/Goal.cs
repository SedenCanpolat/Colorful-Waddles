using System.Collections;
using System.Collections.Generic;
using Holylib.HolySoundEffects;
using UnityEngine;


public class Goal : MonoBehaviour
{
    public GameObject ColorScene;
    public Sprite Bubble;
    public Sprite StartBubble;
    public SpriteRenderer SpriteRenderer;

    public Item PersonalizedItem;
    //public GameObject dialogueBubble;
    public int FlagMission = 0;

    [SerializeField] AudioClip colorSFX;
    [SerializeField] AudioClip laughSFX;


    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer.sprite = StartBubble;
        SetColorfulMap(false);
    }


    public void CloseDialogue()
    {
        //dialogueBubble.SetActive(false);
        SpriteRenderer.sprite = null;
        gameObject.LeanRotateAround(Vector3.left + Vector3.forward + Vector3.right, 20f, 0.3f).setLoopPingPong();
        SetColorfulMap(true);
        SceneManagement.instance.IncreaseColorCount();
        SoundEffectController.PlaySFX(colorSFX).SetVolume(1.30f);
        Invoke("playlaughsfx", 0.7f);
    }

    void playlaughsfx()
    {
        SoundEffectController.PlaySFX(laughSFX).SetVolume(1.45f);
    }

    public void OpenDialogue()
    {
        if (FlagMission == 0)
        {
            Debug.Log("OpenDialogue");
            SpriteRenderer.sprite = Bubble;
            FlagMission = 1;
        }
    }

    public void SetColorfulMap(bool state)
    {
        ColorScene.SetActive(state);
    }


}
