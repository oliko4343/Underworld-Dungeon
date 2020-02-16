using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public Animator animator;

    public int health;



    public GameObject deathFX;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("DAMAGE TAKEN!");



    }
    void Die()
    {
        animator.SetBool("IsDead", true);


    }
}
