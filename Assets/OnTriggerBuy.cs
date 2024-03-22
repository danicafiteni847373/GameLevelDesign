using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTriggerBuy : MonoBehaviour
{
    public Canvas myCanvas; //Your target for the refference

    void Start()
    {
        myCanvas.enabled = false;
    }
    void OnTriggerEnter(Collider collision)
    {
        if (myCanvas.enabled == false)
        {
            collision.CompareTag("Player");
            myCanvas.enabled = true;
        }

    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            myCanvas.enabled = false;
        }

    }


}
