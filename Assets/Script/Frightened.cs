using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Frightened : MonoBehaviour
{
    int amount = 0;
    [SerializeField] private Image image;

    //The player walking somewhere will trigger the picture popup event.
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
	   if( amount == 0 )
	   {
            image.enabled = true;
			GetComponent<AudioSource>().Play();
			amount++;
	   }
	}
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            image.enabled = false;
        }
    }
    
}
