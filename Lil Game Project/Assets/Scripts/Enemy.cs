using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int maxHealth;
    public int currentHealth;
    public int Damage;
    public Health healthBar;
    
    void Start()
    {

        maxHealth = 10;
        currentHealth = 10;
        Damage = 1;
        healthBar.SetMaxHealth(maxHealth);
        
        
    }

}
