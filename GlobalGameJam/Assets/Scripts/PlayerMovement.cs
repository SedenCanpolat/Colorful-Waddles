using System.Collections;
using System.Collections.Generic;
using Holylib.HolySoundEffects;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private bool isMoving;
    private Vector2 input;
    public Animator animator;
    public Rigidbody2D rb;

    [SerializeField] AudioClip walkSFX;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       // SoundEffectController.PlaySFX(walkSFX);
    }

    SoundSource walksound;
    void FixedUpdate()
    {
        animator.SetBool("walk", true);
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        rb.velocity = input * moveSpeed * Time.fixedDeltaTime;
        

        if (input.x == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (input.x == -1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        //if (input.x != 0) input.y = 0;

        if (input != Vector2.zero)
        {
            var targetPos = transform.position;
            targetPos.x += input.x;
            targetPos.y += input.y;

            if(!walksound)
                walksound = SoundEffectController.PlaySFX(walkSFX).SetVolume(0.3f).SetLoop(true);
        }

        else
        {
            animator.SetBool("walk", false);

            if(walksound)
            {
                SoundEffectController.StopSFX(walksound);
                walksound = null;
            }
        }

    }

    public void Preslide()
    {
        animator.SetTrigger("preslide 0");

        // animator.SetBool("preslide", false);

    }





}
