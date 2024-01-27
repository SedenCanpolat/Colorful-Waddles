using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectTake : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;

    public Item inventory;

    private void OnTriggerEnter2D(Collider2D other) { // other == item
                if(other.GetComponent<ItemObject>() && inventory == null){
                    inventory = other.GetComponent<ItemObject>().item;
                    Destroy(other.gameObject);
                    SpriteRenderer.sprite = inventory.sprite;
                }  
    }


    public void giveItem(){
        inventory = null;
        SpriteRenderer.sprite = null;
    }

    public void dropItem(){
      // inventory.GetComponent<ItemObject>().item;
    }

}


