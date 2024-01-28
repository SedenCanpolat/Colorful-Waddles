using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.HolySoundEffects;

public class GiveObject : MonoBehaviour
{
   
    Item inventory;
    [SerializeField] AudioClip WrongSFX;

    private void OnTriggerEnter2D(Collider2D other) {
        inventory = GetComponent<ObjectTake>().inventory;
        if(other.GetComponent<Goal>() && inventory != null){
            if(other.GetComponent<Goal>().PersonalizedItem == inventory){
                Debug.Log("You did it!");
                GetComponent<ObjectTake>().giveItem();
                other.GetComponent<Goal>().CloseDialogue();
                
            }
            
            else{
                // wrong item voice
                SoundEffectController.PlaySFX(WrongSFX).SetVolume(1.45f).SetPitch(0.60f);
                } 
            
            }
            
    }
}
