using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossEncounter : MonoBehaviour
{
	void OnTriggerEnter(Collider Info)
	{
	        //this is on trigger event that will be appeared on Level 5, players will have a battle with boss 
		if (Info.tag == "Player")
		{
			GameObject obj = GameObject.FindWithTag("Player");
			PlayerController controller = obj.GetComponent<PlayerController>();
			SceneManager.LoadScene("FinalBossBattle");
		}

	}
}
