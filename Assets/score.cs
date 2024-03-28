using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    static public int myScore;

    void Update()
    {
        GetComponent<Text>().text = "Score : " + myScore;
    }
}
