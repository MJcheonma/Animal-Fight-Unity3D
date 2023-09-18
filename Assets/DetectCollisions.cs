using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        

        if(GameObject.FindWithTag("animals2"))
        {
            transform.Rotate(0, 90, 0);
        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            //Destroy(GameObject.FindWithTag("Player"));
            GameObject tmp = GameObject.FindWithTag("Player");
            while (tmp != null)
            {
                Destroy(tmp);
                tmp = GameObject.FindWithTag("Player");
            }
        }
    }
}
