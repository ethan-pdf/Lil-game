using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health;
    public int Damage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = 10;
        Damage = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
