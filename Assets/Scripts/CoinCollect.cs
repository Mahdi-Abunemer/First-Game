using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public GameObject textScore;
    public static int coinCount; 
      void OnTriggerEnter(Collider other)
       {
        if (other.tag == "Player")
        {
            coinCount += 1; 
            textScore.GetComponent<Text>().text = "SCORE: " + coinCount; 
            this.gameObject.SetActive(false);
        }

       }
   
}
