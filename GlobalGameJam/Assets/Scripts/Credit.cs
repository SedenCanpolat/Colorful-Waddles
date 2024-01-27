using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : MonoBehaviour
{
   [SerializeField] GameObject creditScreen;

    // Start is called before the first frame update
    void Start()
    {
        creditScreen.SetActive(false);
    }

    // Update is called once per frame
     public void CreditOn()
    {
        creditScreen.SetActive(true);
    }

    public void CreditOff(){
        creditScreen.SetActive(false);
    }
}
