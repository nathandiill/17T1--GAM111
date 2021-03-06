﻿using UnityEngine;
using System.Collections;

public class TennisNet : MonoBehaviour {

    public float fixedDamage;
    public float pushAwaySpeed = 10;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            var hp = col.gameObject.GetComponent<Health>();
            hp.TakeDamage(fixedDamage);
            col.rigidbody.AddForce((col.transform.position - transform.position).normalized * pushAwaySpeed, ForceMode.VelocityChange);
            
            // Call functions on other scripts
            SoundManager.Instance.TennisNetSound();
            Score.Instance.TennisNetScore(-5);
            Health.Instance.TakeDamage(20);
        }
    }
}
