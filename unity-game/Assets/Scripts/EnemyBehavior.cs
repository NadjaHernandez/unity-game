using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class EnemyBehavior : MonoBehaviour
{
    Rigidbody2D enemyRigidbody;
    public float enemyMaxHealth;
    public float enemyHealth;
    public bool hurt;

    public bool attacking = false;
    public float timeBetweenAttacks;
    public float attackCools;
    public float timeBetweenHurt;
    public float hurtCools;

    public float distance;
    public float attackRange;
    public enum enemyStates { idle, attack, walk, corpse }
    public enemyStates currentState = enemyStates.idle;

    Animator anim;
    //PlayerController player;
    SpriteRenderer rend;
    
    private void Awake()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
        enemyHealth = enemyMaxHealth;
        anim = GetComponent<Animator>();
        hurt = false;
        //rend = GetComponent<SpriteRenderer>;

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
