using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour {

    void OnCollisionEnter()
    {
        // On Collision with the final wall, load the victory scene
        SceneManager.LoadScene(4);
    }
}
