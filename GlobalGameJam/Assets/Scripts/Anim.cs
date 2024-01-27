using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.LeanRotateAround(Vector3.left + Vector3.forward + Vector3.right, 20f, 0.3f).setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
