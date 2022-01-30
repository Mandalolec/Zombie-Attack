using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public int healthEnemy;
    public float speedEnemy;
    private float speedEnemyRotate = 100f;
    public GameObject deathEffect;
    public GameObject enemy;
    private PlayerController player;
    private Animator anim;
    public int enemyCost;


private void Start() 
{
    player = FindObjectOfType<PlayerController>();
    anim = GetComponent<Animator>();
}
    private void Update() 
    {
        if (healthEnemy <= 0)
        {
            Kill();      
        }
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speedEnemy * Time.deltaTime);
        Quaternion targetRotation = Quaternion.LookRotation(player.transform.position);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * speedEnemyRotate);

        if (speedEnemy == 0)
        {
            anim.SetBool("isWalking", false);
        }
        else 
        {
            anim.SetBool("isWalking", true);
        }
    }
    public void TakeDamage(int damage)
    {
        healthEnemy -= damage;
    }
    public void Kill()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        speedEnemy = 0;
        Destroy(gameObject);       
        ScoreCount.enemys += enemyCost;
    }
}
