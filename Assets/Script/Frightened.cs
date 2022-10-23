using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Frightened : MonoBehaviour
{
    [SerializeField] private Image image;

    //The player walking somewhere will trigger the picture popup event.
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            image.enabled = true;
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
