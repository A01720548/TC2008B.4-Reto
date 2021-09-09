using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideCars : MonoBehaviour
{
    public bool visible;
    void start()
    {
        visible = true;
    }

    void OnCollisionEnter(Collision col)
    {
        if (visible == true)
        {
            if (col.gameObject.tag == "car")
            {
                col.gameObject.GetComponent<MeshRenderer>().enabled = false;
                visible = false;
            }
        }
        else
        {
            if (col.gameObject.tag == "car")
            {
                col.gameObject.GetComponent<MeshRenderer>().enabled = true;
                visible = true;
            }
        }
    }
}
