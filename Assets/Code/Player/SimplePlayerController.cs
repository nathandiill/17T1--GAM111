using UnityEngine;
using System.Collections;

public class SimplePlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float torqueScale = 1;
    public Vector3 previousTorque;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () 
    {
        var inputRot = Camera.main.transform.rotation;
        var tmp = inputRot.eulerAngles;
        tmp.x = 0;
        tmp.z = 0;
        inputRot = Quaternion.Euler(tmp);

        var torqueDir = new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal")).normalized;
        torqueDir = inputRot * torqueDir;

        previousTorque = torqueDir * torqueScale;

        rb.AddTorque(previousTorque);

        Debug.DrawRay(transform.position, previousTorque, Color.red);
	}
}
