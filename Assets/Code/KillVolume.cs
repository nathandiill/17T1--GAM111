﻿using UnityEngine;
using System.Collections;

public class KillVolume : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
    }
}
