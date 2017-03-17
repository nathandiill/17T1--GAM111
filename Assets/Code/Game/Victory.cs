using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour {

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    void OnCollisionEnter()
    {
        SceneManager.LoadScene(4);
    }
}
