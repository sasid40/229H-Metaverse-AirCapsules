using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Body")
        {
            score.myScore += 1;

            Destroy(gameObject);
        }
    }//OnTriggerEnter

}//Coin
