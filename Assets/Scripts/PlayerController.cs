using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     float yValue = 0;
     public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instructiuni();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void Instructiuni()
    {
        Debug.Log("bine ai venit, rau ai nimerit!");
        Debug.Log("misca-te!");
        Debug.Log("gandeste inainte sa faci!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xValue, yValue, zValue);
    }
}
