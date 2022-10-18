using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinManager : MonoBehaviour
{
    private static int diamondAmount = 0;
    void Start()
    {
        if (SaveManager.instance.hasLoaded)
        {
            diamondAmount = SaveManager.instance.activeSave.diamondAmount;
		}
    }

    [SerializeField] private Text coinText;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("money"))
        {
            Debug.Log("amount:" + diamondAmount);
            Destroy(collision.gameObject);

            diamondAmount++;
            coinText.text = "COIN:" + diamondAmount;
        }
	}
}
