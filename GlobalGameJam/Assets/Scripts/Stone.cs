using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stone : MonoBehaviour
{
    public Animator animator;
    public Goal goal;
    public PlayerMovement playerMovement;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TripCount()
    {
        playerMovement.Preslide();
        
    }
}
