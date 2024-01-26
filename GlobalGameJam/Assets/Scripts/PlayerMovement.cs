using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private bool isMoving;

    private Vector2 input;

    public Animator animator;
    public Rigidbody2D rb;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {

        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        rb.velocity = input * moveSpeed;
        if (!isMoving)
        {


            if (input.x == 1)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            if (input.x == -1)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }

            if (input.x != 0) input.y = 0;

            if (input != Vector2.zero)
            {
                var targetPos = transform.position;
                targetPos.x += input.x;
                targetPos.y += input.y;


            }
        }
        else
        {
            animator.SetBool("walk", false);
        }

    }

    void Move(Vector3 targetPos)
    {
        animator.SetBool("walk", true);
        isMoving = true;


        // while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        // {

        //     // transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);

        // }
        transform.position = targetPos;

        isMoving = false;
    }
    // Update is called once per frame

}
