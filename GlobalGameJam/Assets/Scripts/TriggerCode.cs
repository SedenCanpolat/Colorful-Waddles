using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        //if (other.gameObject.GetComponent<Goal>()) is null or not == ?
            other.gameObject.GetComponent<Goal>()?.OpenDialogue(); // script is Goal.cs
    }
}
