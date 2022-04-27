using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDamage : MonoBehaviour
{public int maxHealth=100;
public int currentHealth;
    Collider2D mycollider;
    int i = 0;
    public HealthBarDrop HealthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        HealthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TakeDamage(int Damage)
    { currentHealth -= Damage; }

    void OnTriggerStay2D(Collider2D mycollider)
    {       
        if (i == 20)
        {
            TakeDamage(5);
            HealthBar.SetHealth(currentHealth);
    i = 0;
        }
        else i++;}

}
