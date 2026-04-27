using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int c = 0;
   private void OnCollisionEnter(Collision other)
   {
       if(other.gameObject.tag != "hit")
       {
           c++;
           Debug.Log("You've bumped on a thing " + c + " times");
       }
       
   }
}
