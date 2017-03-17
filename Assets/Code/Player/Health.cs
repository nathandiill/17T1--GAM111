using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float hpRemaining;

    public void TakeDamage(float dmg)
    {
        hpRemaining -= dmg;

        if (hpRemaining <= 0)
            Destroy(gameObject);
    }
}
