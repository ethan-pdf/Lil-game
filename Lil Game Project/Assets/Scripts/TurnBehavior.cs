using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public enum BattleState { START, PLAYER, ENEMY, WIN, LOSE }





public class TurnBehavior : MonoBehaviour
{

    public BattleState state;

    public Button AttackButton;

    public Button DefendButton;

    public Button ItemButton;

    public Player user;

    public Enemy baddie;

    public TextMeshProUGUI currentTurnLabel;

    public TextMeshProUGUI playerActionLabel;

    public TextMeshProUGUI enemyActionLabel;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("AttackButton is null? " + (AttackButton == null));
        Debug.Log("user is null? " + (user == null));
        Debug.Log("baddie is null? " + (baddie == null));

        state = BattleState.PLAYER;

        playerTurn();

    }


    // Update is called once per frame
    void Update()
    {

    }

    // // Handles the order of a battle. Unused for now?
    // void BattleBehavior()
    // {

    //     //  Debug.Log("test");
    //     // AttackButton.GetComponent<Button>().onClick.AddListener(() => AttackPress(user, baddie));

    // }

    // Handles the control for a player's turn


    void playerTurn()
    {

        currentTurnLabel.text = "Player's Turn!";

        buttonsEnable();

    }


    // Handles the enemies possible actions
    void enemyTurn()
    {

    }


    // void AttackPress(Player p, Enemy e)
    // {

    //     e.Health -= 1;
    //     Debug.Log("Attacked");
    //     Debug.Log("Enemy HP: " + e.Health);
    //     // checkHealth(e);

    // }

    // Function handles the player attacking the enemy
    IEnumerator playerAttack()
    {

        buttonsDisable();

        // Sets the currentActionLabel 
        playerActionLabel.text = "Player attacks! Deals " + user.Damage + " damage!";

        // Updates the enemies health using the user's damage
        baddie.currentHealth -= user.Damage;

        // Waits for 2 seconds so users can digest. :yummy:
        yield return new WaitForSeconds(2f);

        // Ends the game if checkHealth returns true, meaning someone died
        if (checkHealth())
        {

            gameEnded();

        }

        // Calls enemies turn otherwise

        enemyTurn();

    }


    // Handles the Attack button being clicked
    public void attackButtonClick()
    {
        Debug.Log("Attack clicked");
        StartCoroutine(playerAttack());
    }


    // Disables all buttons upon being called
    void buttonsDisable()
    {
        
        //Updates all buttons to be uninteractable
        AttackButton.interactable = false;

        DefendButton.interactable = false;

        ItemButton.interactable = false;

    }


    // Enables all buttons upon being called
    void buttonsEnable()
    {
        
        //Updates all buttons to be interactable
        AttackButton.interactable = true;

        DefendButton.interactable = true;

        ItemButton.interactable = true;

    }



    // Checks both the player and enemies health to see if one has died
    bool checkHealth()
    {

        // Returns true if either the player or enemies health is below or at 0.
        if (user.currentHealth <= 0 || baddie.currentHealth <= 0)
        {
            return true;
        }

        return false;

    }

    // Handles the end of game state
    void gameEnded()
    {
        
    }
}
