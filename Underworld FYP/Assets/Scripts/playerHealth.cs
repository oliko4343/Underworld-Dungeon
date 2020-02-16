using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class playerHealth : MonoBehaviour
{

    public float fullHealth;
    public GameObject deathFX;
    

    float currentHealth;


    Bandit controlMovement;



    //HUD Variables

    public Slider healthSlider;
    public Image damageScreen;

    bool damaged = false;
    Color damagedColor = new Color(0f, 0f, 0f, 1f);
    float smoothColour = 5f;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = fullHealth;

        controlMovement = GetComponent<Bandit>();

        //HUD Initialization
        healthSlider.maxValue = fullHealth;
        healthSlider.value = fullHealth;



    }



    // Update is called once per frame
    void Update()
    {
        if (damaged)
        {
            damageScreen.color = damagedColor;
        
        }
        else
        {
            damageScreen.color = Color.Lerp(damageScreen.color, Color.clear, smoothColour * Time.deltaTime);
        }
        damaged = false;
    }

    

    public void addDamage(float damage)
    {
        if (damage <= 0) return;
        currentHealth -= damage;


        healthSlider.value = currentHealth;
        damaged = true;

        if (currentHealth <= 0)
        {
            makeDead();

        }
    }

    public void makeDead()
    {
        Instantiate(deathFX, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}