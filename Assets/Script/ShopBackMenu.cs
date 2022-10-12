using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopBackMenu : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player")
		{
			PlaySound();
            Destroy(gameObject.GetComponent<Renderer>());
			Destroy(gameObject.GetComponent<Collider>());
			Destroy(gameObject,audioClpGet.length);
		}
	}
	
	
	public float MoveRange;
	public float MoveSpeed;
    public void ShopBackToMenu()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
	}
}
