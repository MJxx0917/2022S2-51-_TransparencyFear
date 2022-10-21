using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinManager : MonoBehaviour
{
	public static int diamondAmount = 0;

	[SerializeField] public Text coinText;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("money"))
        {
            Debug.Log("amount:" + diamondAmount);
            Destroy(collision.gameObject);

            diamondAmount++;
            coinText.text = "COIN:" + diamondAmount;
        }

        if(collision.gameObject.CompareTag("Treat"))
		{
			if (diamondAmount > 0 && HealthManager.health < 5)
			{
				Debug.Log("amount:" + diamondAmount);
				diamondAmount--;
				coinText.text = "COIN:" + diamondAmount;
				HealthManager.health++;
			}
		}
	}
}
