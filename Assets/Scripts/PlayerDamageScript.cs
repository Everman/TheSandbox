using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageScript : MonoBehaviour
{

    private int maxHealth = 100;
    private int currentHealth;
    [SerializeField] private HealthBar healthBar = null;

    // Start is called before the first frame update
    void Start()
    {
        if (healthBar == null) { Debug.LogError("ERROR - healthBar in PlayerDamageScript is not set!"); }

        currentHealth = maxHealth;
        healthBar.setHealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(5);
        }
    }

    private void takeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);
    }
}
