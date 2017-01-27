using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spawnPoint;
    public float tijd;
    public bool coolDown = false;
    public Animator staff;
    public SX_Mana mana;

    void Update()
    {
        timer();

        if (tijd > 3)
        {
            coolDown = false;
        }
       

        if (Input.GetButtonDown("Fire1") && coolDown == false && mana.manaRound >= 10 && SX_GameManager.playing == true)
        {
            tijd = 0;
            Vector3 spawnpos = spawnPoint.transform.position;
        
           GameObject fireball =  Instantiate(cubePrefab, spawnpos, Quaternion.identity) as GameObject;
            fireball.GetComponent<SX_FireCast>().spawn = gameObject.GetComponentInChildren<SX_SpawnPoint>();

            coolDown =  true;
            SX_Mana.mana -= 10;
            staff.SetTrigger("Cast");            
        }
    }

    public void timer()
    {
        tijd = tijd + Time.deltaTime;
    }

}
