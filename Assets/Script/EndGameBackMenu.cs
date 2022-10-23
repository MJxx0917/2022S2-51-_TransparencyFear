using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameBackMenu : MonoBehaviour
{
    public void EndBackMenu()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
	}
}
