using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCode : MonoBehaviour
{
    public Goal goal;
    public Stone stone;
    public int count;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Goal>()?.OpenDialogue();
        if (goal.FlagMission == 1)
        {
            if (other.gameObject.GetComponent<Stone>())
            {
                stone.TripCount();
                count++;
            }
            if (count == 3)
            {
                goal.CloseDialogue();
                goal.FlagMission = 2;
            };
            Debug.Log(count);
        }

    }
}
