using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stone : MonoBehaviour
{
    public Animator animator;
    public Goal goal;
    public PlayerMovement playerMovement;
    
    public void TripCount()
    {
        playerMovement.Preslide();
        
    }
}
