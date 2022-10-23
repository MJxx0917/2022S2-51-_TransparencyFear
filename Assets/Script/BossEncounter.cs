using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossEncounter : MonoBehaviour
{
	void OnTriggerEnter(Collider Info)
	{
		if (Info.tag == "Player")
		{
			GameObject obj = GameObject.FindWithTag("Player");
			PlayerController controller = obj.GetComponent<PlayerController>();
			SceneManager.LoadScene("FinalBossBattle");
		}

	}
}
