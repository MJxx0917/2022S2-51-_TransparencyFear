using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseStory: MonoBehaviour
{
	public GameObject gameObject;
	bool active;

        //before every level start, players will read a story and hints, this is a button to close panel;
	public void OpenAndClose()
	{
		if (active == false)
		{
			gameObject.transform.gameObject.SetActive(false);
			active = false;
		}
	}
  
}
