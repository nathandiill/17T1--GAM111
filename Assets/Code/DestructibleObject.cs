using UnityEngine;
using System.Collections;

public class DestructibleObject : MonoBehaviour 
{
    private Health hp;
    public float minThresholdToDamage = 10;

    public float Mass;

    private Vector3 cogOffset;

    public Vector3 COG
    {
        get
        {
            return transform.position + transform.rotation * cogOffset;
        }
    }

    void Start()
    {
        hp = GetComponent<Health>();
    }


    void OnCollisionEnter(Collision col)
    {
        //this needs to be more logical, possibly as a factor of combined mass
        var impact = col.impulse.magnitude;
        impact -= minThresholdToDamage;

        if (impact > 0)
        {
            hp.TakeDamage(impact);
        }
    }
}

public static class DamageCalculator
{
    //need to handle 
    static public void CalculateForMe(DestructibleObject me, Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            CalculateForPlayer(me, col);
        }
    }

    static private void CalculateForPlayer(DestructibleObject me, Collision col)
    {
    }
}
