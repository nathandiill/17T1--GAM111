using UnityEngine;
using System.Collections;

public class Umpire : MonoBehaviour 
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
        var impact = col.impulse.magnitude;
        impact -= minThresholdToDamage;

        if (impact > 0)
        {
            hp.TakeDamage(impact);
        }

        // Call functions on other scripts
        SoundManager.Instance.UmpireSound();
        Score.Instance.UmpireScore(10);
    }
}

public static class DamageCalculator
{
    //need to handle 
    static public void CalculateForMe(Umpire me, Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            CalculateForPlayer(me, col);
        }
    }

    static private void CalculateForPlayer(Umpire me, Collision col)
    {
    }
}
