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
    [SerializeField] AudioClip quackSFX;
    //SoundSource quacksound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       // SoundEffectController.PlaySFX(walkSFX);
       StartCoroutine(Wait());
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
                //float randomTimer = Random.Range(3f, 5f);
                walksound = SoundEffectController.PlaySFX(walkSFX).SetVolume(0.5f).SetLoop(true);
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


    IEnumerator Wait()
    {   
        while(true){
            yield return new WaitForSeconds(Random.Range(5f, 10f));
            SoundEffectController.PlaySFX(quackSFX).SetVolume(0.30f).RandomPitchRange(0.90f, 1.10f);
        
        }
      
    }





}
