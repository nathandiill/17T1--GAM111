using UnityEngine;
using System.Collections;

public class SimpleCameraController : MonoBehaviour 
{
    public GameObject Player;
    public Vector3 Offset;

	void Start ()
    {
        // Set the offset to the player position
        Offset = transform.position - Player.transform.position;	
	}
	
	void LateUpdate () 
    {
        // Add the offset
        transform.position = Player.transform.position + Offset;
    }
}
