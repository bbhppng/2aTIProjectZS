using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    float score = 0;
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            score++;
            Debug.Log("Score: " + score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
