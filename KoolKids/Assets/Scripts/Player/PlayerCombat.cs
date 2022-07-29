using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    private PlayerMovement playerMovement;
    const string PLAYER_ATTACK = "Player_Atk";
    

    void Start()
    {
        GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }
    // Update is called once per frame
    void Update()
    {
        
 
    }

    void Attack()
    {
        GetComponent<PlayerMovement>().ChangeAnimationState(PLAYER_ATTACK); 
    }


}
