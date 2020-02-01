using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += (this.transform.forward * speed); 
        }
    }
}
