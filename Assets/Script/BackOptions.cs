using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackOptions : MonoBehaviour
{
   
    // Update is called once per frame
    void Start()
    {
        
    }

    // Update is called once per frame
    // Start is called before the first frame update
    void Update()
    {
        
    }
    */

    public void VolumeBackOptions()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
	}
}
