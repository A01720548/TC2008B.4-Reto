using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideCars : MonoBehaviour
{
    bool visible = true;
    public GameObject child1;
    void start()
    {
        child1 = this.gameObject.transform.GetChild(0).gameObject;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "appear")
        {
            child1.SetActive(true);
        }
        if (col.tag == "dis")
        {
            child1.SetActive(false);
        }
    }
}