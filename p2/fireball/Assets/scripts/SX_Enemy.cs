using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SX_Enemy : MonoBehaviour {
    public Image enemyHealthBar;
    public float health;
    public float maxHealth;
    public Canvas healthCanvas;
    public Animator fire;
    public Animator fireLight;
    public Vector3 spawnRot;
    public SX_Quest quest;
    public bool dummyDead;
    public Vector3 sinking;
    public Vector3 goingUp;
    public bool goUp;
    
	void Start ()
    {
        goUp = true;
        health = maxHealth;
        healthCanvas.enabled = false;
        if (SX_GameManager.enemyLevel == 1)
        {
            FirstDummy();
        }
        else
        {
            OtherDummy();
        }
    }
	
	void Update ()
    {   if (goUp == true)
        {
            transform.Translate(goingUp);
        }
    if (transform.position.y >= 0.79f)
        {
            goUp = false;
        }
        enemyHealthBar.fillAmount = health / maxHealth;
        if(health <= 0 && dummyDead == false)
        {
            healthCanvas.enabled = false;
            fire.SetTrigger("DummyDead");
            fireLight.SetTrigger("Fire");
            quest.DummysDead();
            dummyDead = true;
            
        }
        if (dummyDead == true)
        {
            healthCanvas.enabled = false;
        }
	    if(quest.times == true)
        {
            transform.Translate(sinking);
        }
	}

    public void OnCollisionEnter(Collision collision)
    {
        int attack;
        if (collision.collider.tag == "FireBall")
        {
            attack = Random.Range(20, 40);
            health -= attack;
            healthCanvas.enabled = true;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        transform.position = new Vector3(Random.Range(-40, 32), 0.758f, Random.Range(-0.5f, 49));
    }

    public void FirstDummy()
    {
        spawnRot = new Vector3(-90, 0, -90);
        transform.eulerAngles = spawnRot;
    }

    public void OtherDummy()
    {
        spawnRot = new Vector3(-90, 0, Random.Range(0, 360));
        transform.eulerAngles = spawnRot;
    }
}
