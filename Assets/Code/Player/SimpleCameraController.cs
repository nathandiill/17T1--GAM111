using UnityEngine;
using System.Collections;

public class SimpleCameraController : MonoBehaviour 
{
    public GameObject Player;
    public Vector3 Offset;

	void Start ()
    {
        Offset = transform.position - Player.transform.position;	
	}
	
	void LateUpdate () 
    {
        transform.position = Player.transform.position + Offset;
    }
}
