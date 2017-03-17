using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    public static Health Instance;

    void Awake()
    {
        Instance = this;
    }

    public float playerHPRemaining = 100;
    public float damageTaken;
    public Text CurrentHealth;

    // Reusable take damage function
    public void TakeDamage(float damageTaken)
    {
        playerHPRemaining -= damageTaken;

        if (playerHPRemaining <= 0)
            Destroy(gameObject);
    }

    void Update()
    {
        // It works but throws up so many errors regardless that the game is unplayable
        // CurrentHealth.text = string.Format("Health: " + playerHPRemaining);
    }
}
