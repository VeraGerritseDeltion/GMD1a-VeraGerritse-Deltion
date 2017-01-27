using UnityEngine;
using System.Collections;

public class SX_FireCast : MonoBehaviour {
    public Animator fireball;
    public Animator light1;
    public float timer;
    public Rigidbody fireballs;
    public SX_SpawnPoint spawn;
    public bool hit;
    public Vector3 hitPosition;
    public bool hitTarget;

	void Update () {
        FireBall();
        if ( timer < 1.25f)
        {
            transform.position = spawn.spawn;
        }
        
        if (timer >= 1.25f)
        {           
           fireballs.AddForce(transform.forward * 50);
        }
        if (timer >= 1.25f && timer <= 1.3f)
        {
            transform.localEulerAngles = spawn.spawnRotation;
        }
        if (timer >= 2.5f && hitTarget == true)
        {
            Destroy(gameObject);
        }        
        if(hit == true)
        {
         transform.position = hitPosition;
        }
	}

    public void FireBall()
    {
        
        timer = timer + Time.deltaTime;
    }

    public void OnCollisionEnter(Collision collision)
    {

        light1.SetTrigger("State3");
        fireball.SetTrigger("State3");
        timer = 0;
        hitTarget = true;

        if (collision.collider.tag == "area")
        {
            hitPosition = transform.position;
            hit = true;
        }
        
       
        
      
    }
}
