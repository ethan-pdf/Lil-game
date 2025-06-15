using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{


    public Button AttackButton;
    public Player user;
    public Enemy baddie;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AttackButton.GetComponent<Button>().onClick.AddListener(() => AttackPress(user, baddie));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void AttackPress(Player p, Enemy e)
    {

        e.Health -= 1;
        Debug.Log("Attacked");
        Debug.Log("Player HP: " + e.Health);
        checkHealth(e);

    }

    void checkHealth(Enemy e)
    {
        if (e.Health == 0)
        {
            Debug.Log("He's Dead!");
            AttackButton.enabled = false;
        } 
    }
}
