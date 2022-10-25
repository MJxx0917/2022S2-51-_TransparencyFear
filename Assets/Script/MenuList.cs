using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuList : MonoBehaviour
{
	public GameObject menuList; // init menuList object

	[SerializeField] private bool menukeys = true; // init boolean of menukeys
	[SerializeField] private AudioSource bgmSound;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (menukeys) // esc core function type false
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				menuList.SetActive(true);
				menukeys = false;
				Time.timeScale = (0);
				bgmSound.Pause();
			}
		}
		else if (Input.GetKeyDown(KeyCode.Escape)) // esc core function type true
		{
			menuList.SetActive(false);
			menukeys = true;
			Time.timeScale = (1);
			bgmSound.Play();
		}
	}

	public void Return()
	{
		menuList.SetActive(false);
		menukeys = true;
		Time.timeScale = 1;
		bgmSound.Play();
	}

	public void Restart()
	{
		SceneManager.LoadScene("Level1");
		Time.timeScale = 1;
		HealthManager.health = 5;
	}
	public void Exit()
	{
		SceneManager.LoadScene("Main_Menu");
		Time.timeScale = 1;
	}
}
