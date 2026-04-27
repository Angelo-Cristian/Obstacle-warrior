using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timp : MonoBehaviour
{
    public int t = 0;
    MeshRenderer renderer;
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
       renderer = GetComponent<MeshRenderer>();
       body = GetComponent<Rigidbody>();

       renderer.enabled = false;
       body.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > t)
        {
            renderer.enabled = true;
            body.useGravity = true;
        }
    }
}
