using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health;
    public int Damage;
    public Health healthBar;



    void Start()
    {
        Health = 10;
        Damage = 1;
        healthBar.SetMaxHealth(Health);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.SetCurrentHealth(Health);
    }
}
