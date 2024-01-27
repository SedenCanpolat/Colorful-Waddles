using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveObject : MonoBehaviour
{
   
    Item inventory;

    private void OnTriggerEnter2D(Collider2D other) {
        inventory = GetComponent<ObjectTake>().inventory;
        if(other.GetComponent<Goal>() && inventory != null){
            if(other.GetComponent<Goal>().PersonalizedItem == inventory){
                Debug.Log("You did it!");
                GetComponent<ObjectTake>().giveItem();
                other.GetComponent<Goal>().CloseDialogue();
                
            }
            /*
            else{
                // wrong item voice
               
                } 
            */
            }
            
    }
}
