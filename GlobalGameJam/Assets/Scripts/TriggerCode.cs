using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.HolySoundEffects;

public class TriggerCode : MonoBehaviour
{
    public Goal goal;
    public Stone stone;
    public int count;
    [SerializeField] AudioClip fallSFX;

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Goal>()?.OpenDialogue();

        if (goal.FlagMission == 1)
        {
            if (other.gameObject.GetComponent<Stone>())
            {
                SoundEffectController.PlaySFX(fallSFX).SetVolume(0.5f);
                stone.TripCount();
                count++;
            }
            if (count == 3)
            {
                goal.CloseDialogue();
                goal.FlagMission = 2;
            };
            Debug.Log(count);
        }
    }
}
