using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Holylib.HolySoundEffects;

public class ObjectTake : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public GameObject ItemPrefab;

    public Item inventory;
    [SerializeField] AudioClip TakeSFX;

    private void OnTriggerEnter2D(Collider2D other) { // other == item
                if(other.GetComponent<ItemObject>() && inventory == null){
                    inventory = other.GetComponent<ItemObject>().item;
                    Destroy(other.gameObject);
                    SpriteRenderer.sprite = inventory.sprite;
                    SoundEffectController.PlaySFX(TakeSFX).SetVolume(1.30f);
                }  
    }


    public void giveItem(){
        inventory = null;
        SpriteRenderer.sprite = null;
    }

    public void dropItem(){
      if(Input.GetKeyDown(KeyCode.X)){
                    Debug.Log("drop item");
                    GameObject droppedItem = Instantiate(ItemPrefab, transform.position + new Vector3(1.15f,0,0), Quaternion.identity);
                    droppedItem.GetComponent<ItemObject>().item = inventory;
                    giveItem();             
            }
    }

    void Update(){
        dropItem();
    }

}


