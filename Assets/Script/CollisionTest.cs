using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CollisionTest : MonoBehaviour 
{	
	void OnTriggerEnter(Collider Info)
	{
		
		if (Info.tag == "Player")
		{
			GameObject obj = GameObject.FindWithTag("Player");
			PlayerController controller = obj.GetComponent<PlayerController>();
			//controller.IsAlive = false;
			HealthManager.health--;
			if (HealthManager.health <= 0)
			{
				controller.IsAlive = false;
				HealthManager.health = 5;
			}
		}
		
	}
}
