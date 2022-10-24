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
		        //judge if player's HP less than 5 and coins are greater than 0
			if (diamondAmount > 0 && HealthManager.health < 5)
			{
				Debug.Log("amount:" + diamondAmount);
				//cost 1 coin to treat player
				diamondAmount--;
				coinText.text = "COIN:" + diamondAmount;
				//treat 1 HP
				HealthManager.health++;
			}
		}
	}
}
