using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class açılış_yazı : MonoBehaviour
{
    public Image opening;

    void Start()
    {
        StartCoroutine(WaitBeforeShow());
    }
    IEnumerator WaitBeforeShow()
    {
        yield return new WaitForSeconds(10);
        Debug.Log("a");
        opening.enabled = false;
    }

    void Update()
    {

    }


}
